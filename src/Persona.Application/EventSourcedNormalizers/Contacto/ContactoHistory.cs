using Newtonsoft.Json;
using Persona.Domain.Core.Enumerations;
using Persona.Domain.Core.Events;
using System.Web;

namespace Persona.Application.EventSourcedNormalizers.Contacto
{
    public static class ContactoHistory
    {
        public static IList<ContactoHistoryData> HistoryData { get; set; }
        public static IList<ContactoHistoryData> ToJavaScriptCustomerHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<ContactoHistoryData>();
            ClienteHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(c => c.Timestamp);
            var list = new List<ContactoHistoryData>();
            var last = new ContactoHistoryData();

            foreach (var change in sorted)
            {
                var jsSlot = new ContactoHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id ? "" : change.Id,
                    IdPersona = change.IdPersona == Guid.Empty.ToString() || change.IdPersona == last.IdPersona ? "" : change.IdPersona,
                    Celular = string.IsNullOrWhiteSpace(change.Celular) || change.Celular == last.Celular ? "" : change.Celular,
                    Correo = string.IsNullOrWhiteSpace(change.Correo) || change.Correo == last.Correo ? "" : change.Correo,
                    Direccion = string.IsNullOrWhiteSpace(change.Direccion) || change.Direccion == last.Direccion ? "" : change.Direccion,

                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    Timestamp = change.Timestamp,
                    Who = change.Who
                };

                jsSlot.Id = HttpUtility.HtmlEncode(jsSlot.Id);
                jsSlot.IdPersona = HttpUtility.HtmlEncode(jsSlot.IdPersona);
                jsSlot.Celular = HttpUtility.HtmlEncode(jsSlot.Celular);
                jsSlot.Correo = HttpUtility.HtmlEncode(jsSlot.Correo);
                jsSlot.Direccion = HttpUtility.HtmlEncode(jsSlot.Direccion);

                list.Add(jsSlot);
                last = change;
            }

            return list;
        }

        private static void ClienteHistoryDeserializer(IEnumerable<StoredEvent> storedEvents)
        {
            foreach (var e in storedEvents)
            {
                var historyData = JsonConvert.DeserializeObject<ContactoHistoryData>(e.Data);

                historyData.Timestamp = DateTime.Parse(historyData.Timestamp).ToString("yyyy'-'MM'-'dd' - 'HH':'mm':'ss");

                switch (e.MessageType)
                {
                    case "ContactoCrearEvent":
                        historyData.Action = HistoryDataEnum.REGISTERED.Name;
                        historyData.Who = e.User;
                        break;

                    case "ContactoModificarEvent":
                        historyData.Action = HistoryDataEnum.UPDATED.Name;
                        historyData.Who = e.User;
                        break;

                    case "ContactoEliminarEvent":
                        historyData.Action = HistoryDataEnum.REMOVED.Name;
                        historyData.Who = e.User;
                        break;

                    default:
                        historyData.Action = HistoryDataEnum.UNRECOGNIZED.Name;
                        historyData.Who = e.User ?? "Anonymous";
                        break;
                }

                HistoryData.Add(historyData);
            }
        }
    }
}
