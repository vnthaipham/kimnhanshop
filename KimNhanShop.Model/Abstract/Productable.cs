using System;
using System.ComponentModel.DataAnnotations;

namespace KimNhanShop.Model.Abstract
{
    public abstract class Productable : IAuditable, ISeoable, ISwitchable
    {
        [MaxLength(256)]
        public string CreatedBy
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? CreatedDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        [MaxLength(256)]
        public string MetaDescripton
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        [MaxLength(256)]
        public string MetaKeyword
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        [MaxLength(50)]
        public bool Status
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        [MaxLength(256)]
        public string UpdatedBy
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? UpdatedDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}