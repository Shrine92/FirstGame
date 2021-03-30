using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame.Core.Data.Models
{
    public class Response
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier page.
        /// </summary>
        /// <value>
        /// The identifier page.
        /// </value>
        public int IdQuestion { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the next page identifier.
        /// </summary>
        /// <value>
        /// The next page identifier.
        /// </value>
        public int NextPageId { get; set; }
    }
}
