using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.Models
{
	public class Movie
	{
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required]
		public String CreatorId { get; set; }

		public ApplicationUser Creator { get; set; }

		public DateTime Created { get; set; }

		public DateTime Modified { get; set; }

		[Required]
		[MaxLength(200)]
		public String Title { get; set; }

		[Required]
		public String Description { get; set; }

		[Required]
		public int Release { get; set; }

		[Required]
		public String Producer { get; set; }

		[Required]
		public String Poster { get; set; }
	}
}
