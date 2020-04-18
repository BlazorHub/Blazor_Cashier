﻿using System;

namespace BlazorCashier.Shared.DomainModels
{
    /// <summary>
    /// Represents the base data of all domain models
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Entity identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The date the current organization was inserted
        /// By default set to the current global time
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;

        /// <summary>
        /// The date that the organization was last modified
        /// By default set to the current global time
        /// </summary>
        public DateTimeOffset LastModifiedDate { get; set; } = DateTimeOffset.UtcNow;
    }
}
