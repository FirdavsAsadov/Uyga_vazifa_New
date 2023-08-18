using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_CT_Task4
{
    internal class MoveService
    {
        private readonly List<Move> _moveList = new List<Move>();
        public IEnumerable<Move> Search(string searchkeyword)
        {
           return _moveList.Where(x => x.Name.Contains(searchkeyword, StringComparison.OrdinalIgnoreCase) || x.Author.Contains(searchkeyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public bool Add(string name, string author, int rating)
        {
            if (_moveList.Any(x => x.Name == name && x.Author == author && x.Rating == rating))
            {
                return false;
            }
            else
            {
                _moveList.Add(new Move(name, author, rating));
            }
            return true;

        }
        public IEnumerable<Move> GetByRating()
        {
           return _moveList.OrderBy(x => x.Rating).ToList();
            
        }
    }
}
