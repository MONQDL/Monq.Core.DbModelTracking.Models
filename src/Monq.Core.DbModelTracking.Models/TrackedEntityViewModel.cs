﻿namespace Monq.Core.DbModelTracking.Models
{
    /// <summary>
    /// Модель представления трекера
    /// </summary>
    public class TrackedEntityViewModel
    {
        /// <summary>
        /// Дата добавления сущности в формате Unixtimestamp.
        /// </summary>
        public long CreatedAt { get; set; }

        /// <summary>
        /// Id пользователя, который создал сущность.
        /// -1 для системного пользователя,
        /// null, если пользователь не определён или неопределим,
        /// остальные значения - Id конкретного пользователя.
        /// </summary>
        public long? CreatedBy { get; set; }

        /// <summary>
        /// Имя пользователя, который создал сущность.
        /// Для системного пользователя - "Системный пользователь"
        /// </summary>
        public string? CreatedByName { get; set; }

        /// <summary>
        /// Дата обновления сущности (названия/описания) в формате Unixtimestamp.
        /// </summary>
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// Id пользователя, который обновил сущность.
        /// -1 для системного пользователя,
        /// Null, если пользователь не определён или неопределим,
        /// остальные значения - Id конкретного пользователя.
        /// </summary>
        public long? UpdatedBy { get; set; }

        /// <summary>
        /// Имя пользователя, который обновил сущность.
        /// Для системного пользователя - "Системный пользователь"
        /// </summary>
        public string? UpdatedByName { get; set; }
    }
}
