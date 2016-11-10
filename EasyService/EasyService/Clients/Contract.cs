using System;

namespace EasyService.Clients
{
    public class Contract
    {
        #region StaticMembers
        static int _id = 0;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public DateTime SignDate { get; private set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }

        #endregion

        #region Constructors

        public Contract()
        {
            Id = GenerateId() + (++_id);
        }

        public Contract(DateTime endDate,string description)
        {
            Id = GenerateId() + (++_id);
            SignDate = DateTime.Now;
            EndDate = endDate;
            Description = description;
        }


        #endregion

        #region Methods
        int GenerateId()
        {
            return DateTime.Now.Year;
        }
        #endregion


    }
}