﻿namespace SUPBank.Domain.Entities
{
    public class EntityMenu : EntityBase
    {
        /// <summary>
        /// Identifier of the parent menu item. 0 if it is the top-level parent menu item.
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// Turkish name of the menu item
        /// </summary>
        public string Name_TR { get; set; } = string.Empty;

        /// <summary>
        /// English name of the menu item
        /// </summary>
        public string Name_EN { get; set; } = string.Empty;

        /// <summary>
        /// Screen code associated with the menu item. The code must be within the range starting from 10000.
        /// </summary>
        public int? ScreenCode { get; set; }

        /// <summary>
        /// URL of the web resource associated with the menu item
        /// </summary>
        public string WebURL { get; set; } = string.Empty;

        /// <summary>
        /// Type of the menu item (e.g., profile menu = 10, my world menu = 20, all transactions = 30)
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// Priority of the menu item for ordering
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Indicates if the menu item is related to search functionality (1 for true, 0 for false)
        /// </summary>
        public bool IsSearch { get; set; }

        /// <summary>
        /// Keyword associated with the menu item for searching
        /// </summary>
        public string Keyword { get; set; } = string.Empty;

        /// <summary>
        /// Authority level required to access the menu item
        /// </summary>
        public int Authority { get; set; }

        /// <summary>
        /// Path to the icon associated with the menu item
        /// </summary>
        public string? Icon { get; set; }

        /// <summary>
        /// Indicates whether the menu item is a group
        /// </summary>
        public bool IsGroup { get; set; }

        /// <summary>
        /// Indicates whether the menu item is new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// Start date for the new menu item
        /// </summary>
        public DateTime? NewStartDate { get; set; }

        /// <summary>
        /// End date for the new menu item
        /// </summary>
        public DateTime? NewEndDate { get; set; }


        public List<EntityMenu> SubMenus { get; set; } = [];
    }
}
