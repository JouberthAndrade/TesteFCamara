using Flunt.Notifications;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCamara.Shared.Base.Interface
{
    public interface IEntityBase<TPrimaryKey>
    {
        TPrimaryKey Id { get; }
        [JsonIgnore]
        IReadOnlyCollection<Notification> Notifications { get; }
        [JsonIgnore]
        bool Invalid { get; }
        [JsonIgnore]
        bool Valid { get; }
    }
}
