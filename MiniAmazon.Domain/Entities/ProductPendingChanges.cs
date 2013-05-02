﻿using System;

namespace MiniAmazon.Domain.Entities
{
    public class ProductPendingChanges : IEntity
    {
        public virtual long Id { get; set; }
        public virtual DateTime CreateDateTimePendingChange { get; set; }
        public virtual string Comments { get; set; }
        public virtual bool Approved { get; set; }
        public virtual string CommentsWhyNotApproved { get; set; }


        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual decimal Price { get; set; }

        public virtual DateTime CreateDateTime { get; set; }

        public virtual string Picture { get; set; }

        public virtual string YoutubeLink { get; set; }

        public virtual int Inventory { get; set; }

        public virtual bool PostOnFacebook { get; set; }

        public virtual bool Active { get; set; }

        public virtual bool PendingChange { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual long AccountId { get; set; }

        public virtual long ProductId { get; set; }

        public static ProductPendingChanges CopyData(Product item)
        {
            var itemWithChanges = new ProductPendingChanges
            {
                CreateDateTime = item.CreateDateTime,
                CreateDateTimePendingChange = DateTime.Now,
                Comments = "",
                CommentsWhyNotApproved = "",
                CategoryId = item.CategoryId,
                Description = item.Description,
                Inventory = item.Inventory,
                Name = item.Name,
                PendingChange = true,
                Picture = item.Picture,
                PostOnFacebook = item.PostOnFacebook,
                Price = item.Price,
                YoutubeLink = item.YoutubeLink,
                ProductId = item.Id,
                Active = item.Active,
                Approved = false,
                AccountId = item.AccountId

            };

            return itemWithChanges;
        }

    }


}