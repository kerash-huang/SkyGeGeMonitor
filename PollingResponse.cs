using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SkyGeGe
{
    /**
     * {"eventMessages":[{"id":1036,"type":"EventMessage","resourceType":"NewMessage","time":"2024-05-08T03:19:56Z","resourceLink":"https://azeus1-client-s.gateway.messenger.live.com/v1/users/ME/conversations/8:kerashman/messages/1715138396357","resource":{"ackrequired":"https://azeus1-client-s.gateway.messenger.live.com/v1/users/ME/conversations/ALL/messages/1715138396357/ack","type":"Message","from":"https://azeus1-client-s.gateway.messenger.live.com/v1/users/ME/contacts/8:kerashman","conversationLink":"https://azeus1-client-s.gateway.messenger.live.com/v1/users/ME/conversations/8:kerashman","version":"1715138396357","messagetype":"Control/Typing","counterpartymessageid":"1715138396357","imdisplayname":"kerashman","composetime":"2024-05-08T03:19:55.601Z","origincontextid":"0","originalarrivaltime":"2024-05-08T03:19:55.601Z","threadtopic":"kerashman, live:.cid.fac74ec072e0c322","contenttype":"Application/Message","mlsEpoch":"0","isactive":true,"id":"1715138396357","properties":{}}}]}
     */
    [DataContract]
    public class PollingResponse
    {
        [DataMember(Name = "eventMessages")]
        public List<EventData> eventMessages { get; set; }
    }
    [DataContract]
    public class EventData
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "resourceType")]
        public string resourceType { get; set; }

        [DataMember(Name = "time")]
        public string time { get; set; }

        [DataMember(Name = "resourceLink")]
        public string resourceLink { get; set; }

        [DataMember(Name = "resource")]
        public ResourceBody resource { get; set; }

    }

    [DataContract]
    public class ResourceBody
    {
        [DataMember(Name = "type")]
        public string type { get; set; }
        [DataMember(Name = "imdisplayname")]
        public string imdisplayname { get; set; }

        [DataMember(Name = "content")]
        public string content { get; set; }
        [DataMember(Name = "threadtopic")]
        public string threadtopic { get; set; }
    }


}
