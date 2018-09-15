using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web2.Models
{
    public class HealthDept
    {
        //note the decoration on top
        [StringLength(202)]
        public string FACILITY_NAME { get; set; }

        [StringLength(102)]
        public string SITE_ADDRESS { get; set; }

        [StringLength(52)]
        public string CITY { get; set; }

        [StringLength(6)]
        public string STATE { get; set; }

        [StringLength(22)]
        public string ZIP { get; set; }

        [StringLength(26)]
        public string OWNER_KEY { get; set; }

        [StringLength(202)]
        public string OWNER_NAME { get; set; }

        [StringLength(25)]
        public string NATURE_OF_BUSINESS { get; set; }

        [StringLength(16)]
        public string STREET_NUMBER { get; set; }

        [StringLength(52)]
        public string STREET_NAME { get; set; }

        [StringLength(10)]
        public string STREET_TYPE { get; set; }

        [StringLength(6)]
        public string POST_DIRECTIONAL { get; set; }

        [StringLength(42)]
        public string PHONE { get; set; }

        [StringLength(10)]  //Id
        public string PROGRAM_CATEGORY { get; set; }
        

        public string PROGRAM_CATEGORY_DES { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime INSPECTION_DATE  {get; set; }

        [StringLength(4)]
        public string INSPECTION_TYPE { get; set; }

        [StringLength(102)]
        public string INSPECTION_DESC { get; set; }

        [StringLength(22)]
     public string SERIAL_NUM { get; set; } //Unique ID


        // OWNER_ID and INSPECTION_DATE and SERIAL_NUM,< it means that there were
        // multiple rows created for one inspection (multiple results were recorded). If there are
        // multiple  rows with the same OWNER_ID and INSPECTION_DATE and a different
        // SERIAL_NUM, it  means that there were multiple inspections taken on the same day // and the  highest  SERIAL_NUM is intended to be the most recent inspection. >
        [StringLength(102)]
        public string ACTION_CODE { get; set; }


        // Code of the action taken. If the ACTION_CODE is equal to 00 – NON-GRADED this // indicates  that the inspector was unable to actually perform an inspection. The
        // RESULT_CODE /documents the situation. 
        [StringLength(4)]
        public string ACTION_DESC { get; set; }

        [StringLength(6)]
        public string RESULT_CODE { get; set; }

        [StringLength(102)]
        public string RESULT_DESC { get; set; }

        [StringLength(14)]
        public string VIOLATION_CODE { get; set; }

        [StringLength(202)]
        public string VIOLATION_DESC(NVL(SNV, VD) { get; set; }

        [StringLength(502)]
        public string INSPECTION_MEMO { get; set; }
        


}
}
