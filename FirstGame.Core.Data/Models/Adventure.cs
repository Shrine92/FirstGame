using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstGame.Core.Data.Models
{
    public class Adventure
    {
        #region props
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
        #endregion
    }
}
