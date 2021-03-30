using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame.Core.Data.Models
{
    public class Question
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
        public int IdPage { get; set; }

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

        public Page Page { get; set; }

        /// <summary>
        /// Gets or sets the responses.
        /// </summary>
        /// <value>
        /// The responses.
        /// </value>
        public List<Response> Responses { get; set; }
    }
}
