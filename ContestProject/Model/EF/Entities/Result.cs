using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestProject.Model.EF.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContestId { get; set; }
        public string ResultContest { get; set; }
        public Contest Contest { get; set; }
        public User User { get; set; }
    }
}
