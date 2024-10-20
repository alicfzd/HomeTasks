using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingerTask
{
	internal class Song
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				if (value.Length <= 100)
				{
					_name = value;
				}

			}
		}

		private string _genre;

		public string Genre
		{
			get { return _genre; }
			set
			{
				if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
				{
					value = _genre;
				}
				else
				{
					Console.WriteLine("Duzgun janr qeyd edin");

				}
			}
		}

		private double _totalRating;

		public double TotalRating
		{
			get { return _totalRating; }
			set { _totalRating = value; }
		}

		private int _ratingCount;

		public int RatingCount
		{
			get { return _ratingCount; }
			set { _ratingCount = value; }
		}

		private Singer _singer;

		public Singer Singer
		{
			get { return _singer; }
			set { _singer = value; }
		}

		public Song(string name, string genre, Singer signer)
		{
			Name = name;
			Genre = genre;
			Singer = signer;
			TotalRating = 0;
			RatingCount = 0;
		}

		public bool AddRating(double rating)
		{
            if (rating < 0 || rating > 10)
            {
				return false;
			}
			
				_totalRating += rating;
				_ratingCount++;
				return true;
		
		}

        public double GetAverageRating()
        {
            if (_ratingCount == 0) 
			{
                return 0; 
			}

            return _totalRating / _ratingCount;
        }
    }
}

