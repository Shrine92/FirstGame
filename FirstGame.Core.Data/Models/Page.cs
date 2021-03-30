using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame.Core.Data.Models
{
    public class Page
    {
        #region properties
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier question.
        /// </summary>
        /// <value>
        /// The identifier question.
        /// </value>
        public int IdQuestion { get; set; }

        /// <summary>
        /// Gets or sets the nummer.
        /// </summary>
        /// <value>
        /// The nummer.
        /// </value>
        public int Nummer { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        /// <value>
        /// The question.
        /// </value>
        public Question Question { get; set; }
        #endregion
    }
}
