using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Tag
    {
        private int id;
        private String subjectName;
        private String subjectCode;
        private String relatedTag;

        public int Id { get => id; set => id = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string SubjectCode { get => subjectCode; set => subjectCode = value; }
        public string RelatedTag { get => relatedTag; set => relatedTag = value; }
        
    }
}
