using FCamara.Shared.Base.Interface;
using Flunt.Notifications;
using Newtonsoft.Json;
using System;

namespace FCamara.Shared.Base
{
    public abstract class EntityBase<TPrimaryKey> : Notifiable, IEntityBase<TPrimaryKey>
    {
        public virtual DateTime CreatedDate { get; protected set; }
        public virtual DateTime? DeletedDate { get; protected set; }

        [JsonProperty("id")]
        public TPrimaryKey Id { get; protected set; }
    }

    public abstract class EntityBase : EntityBase<Guid>
    {
        protected EntityBase()
        {
            if (Id == Guid.Empty)
            {  // solution for use entity with base for document db entity
                this.Id = Guid.NewGuid();
                this.CreatedDate = DateTime.Now;
            }
        }

        public void Delete()
        {
            this.DeletedDate = DateTime.Now;
        }

        public void SetId(Guid id)
        {
            if (id != Guid.Empty)
                this.Id = id;
        }
    }
}
