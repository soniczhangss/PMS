using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBServiceLib
{
    public class Service : IService
    {

        Property getAPropertyById(int id)
        {
            Property property = new Property();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyRow = from p in pmsdbe.Properties where p.Id == id select p;
                if (propertyRow.Count() != 0)
                {
                    property.Id = propertyRow.First().Id;
                    property.Address = propertyRow.First().Address;
                    property.PropertyOwnerId = propertyRow.First().PropertyOwnerId;
                }
            }
            return property;
        }

        public List<Property> getAllProperties()
        {
            List<Property> properties = new List<Property>();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyRows = from p in pmsdbe.Properties select p;
                foreach (Property propertyRow in propertyRows)
                {
                    Property property = new Property();
                    property.Id = propertyRow.Id;
                    property.Address = propertyRow.Address;
                    property.PropertyOwnerId = propertyRow.PropertyOwnerId;
                    properties.Add(property);
                }
            }
            return properties;
        }

        public void updateAProperty(Property property)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var pty = (from p in pmsdbe.Properties where p.Id == property.Id select p).First();

                pty.Address = property.Address;
                pty.PropertyOwnerId = property.PropertyOwnerId;

                pmsdbe.SaveChanges();
            }
        }

        public void createAProperty(Property property)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                Property p = new Property();
                p.Address = property.Address;
                p.PropertyOwnerId = property.PropertyOwnerId;

                pmsdbe.Properties.Add(p);
                pmsdbe.SaveChanges();
            }
        }

        public void deleteAPropertyById(int id)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyRow = (from p in pmsdbe.Properties where p.Id == id select p).First();
                pmsdbe.Properties.Remove(propertyRow);
                pmsdbe.SaveChanges();
            }
        }

        public PropertyOwner getAPropertyOwnerById(int id)
        {
            PropertyOwner propertyOwner = new PropertyOwner();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyOwnerRow = from p in pmsdbe.PropertyOwners where p.Id == id select p;
                if (propertyOwnerRow.Count() != 0)
                {
                    propertyOwner.Id = propertyOwnerRow.First().Id;
                    propertyOwner.Givenname = propertyOwnerRow.First().Givenname;
                    propertyOwner.Surname = propertyOwnerRow.First().Surname;
                }
            }
            return propertyOwner;
        }

        public List<PropertyOwner> getAllPropertyOwners()
        {
            List<PropertyOwner> propertyOwners = new List<PropertyOwner>();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyOwnerRows = from p in pmsdbe.PropertyOwners select p;
                foreach (PropertyOwner propertyOwnerRow in propertyOwnerRows)
                {
                    PropertyOwner propertyOwner = new PropertyOwner();
                    propertyOwner.Id = propertyOwnerRow.Id;
                    propertyOwner.Givenname = propertyOwnerRow.Givenname;
                    propertyOwner.Surname = propertyOwnerRow.Surname;
                    propertyOwners.Add(propertyOwner);
                }
            }
            return propertyOwners;
        }

        public void updateAPropertyOwner(PropertyOwner propertyOwner)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var ptyOwner = (from p in pmsdbe.PropertyOwners where p.Id == propertyOwner.Id select p).First();

                ptyOwner.Givenname = propertyOwner.Givenname;
                ptyOwner.Surname = propertyOwner.Surname;

                pmsdbe.SaveChanges();
            }
        }

        public void createAPropertyOwner(PropertyOwner propertyOwner)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                PropertyOwner po = new PropertyOwner();
                po.Givenname = propertyOwner.Givenname;
                po.Surname = propertyOwner.Surname;

                pmsdbe.PropertyOwners.Add(po);
                pmsdbe.SaveChanges();
            }
        }

        public void deleteAPropertyOwnerById(int id)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyOwnerRow = (from p in pmsdbe.PropertyOwners where p.Id == id select p).First();
                pmsdbe.PropertyOwners.Remove(propertyOwnerRow);
                pmsdbe.SaveChanges();
            }
        }

        public PropertyManagementFee getPropertyManagementFeeById(int id)
        {
            PropertyManagementFee propertyManagementFee = new PropertyManagementFee();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyManagementFeeRow = from p in pmsdbe.PropertyManagementFees where p.Id == id select p;
                if (propertyManagementFeeRow.Count() != 0)
                {
                    propertyManagementFee.Id = propertyManagementFeeRow.First().Id;
                    propertyManagementFee.Amount = propertyManagementFeeRow.First().Amount;
                    propertyManagementFee.From = propertyManagementFeeRow.First().From;
                    propertyManagementFee.To = propertyManagementFeeRow.First().To;
                }
            }
            return propertyManagementFee;
        }

        public List<PropertyManagementFee> getAllPropertyManagementFees()
        {
            List<PropertyManagementFee> propertyManagementFees = new List<PropertyManagementFee>();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyManagementFeeRows = from p in pmsdbe.PropertyManagementFees select p;
                foreach (PropertyManagementFee propertyManagementFeeRow in propertyManagementFeeRows)
                {
                    PropertyManagementFee propertyManagementFee = new PropertyManagementFee();
                    propertyManagementFee.Id = propertyManagementFeeRow.Id;
                    propertyManagementFee.Amount = propertyManagementFeeRow.Amount;
                    propertyManagementFee.From = propertyManagementFeeRow.From;
                    propertyManagementFee.To = propertyManagementFeeRow.To;
                    propertyManagementFees.Add(propertyManagementFee);
                }
            }
            return propertyManagementFees;
        }

        public void updateAPropertyManagementFee(PropertyManagementFee propertyManagementFee)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var pmf = (from p in pmsdbe.PropertyManagementFees where p.Id == propertyManagementFee.Id select p).First();

                pmf.Amount = propertyManagementFee.Amount;
                pmf.From = propertyManagementFee.From;
                pmf.To = propertyManagementFee.To;

                pmsdbe.SaveChanges();
            }
        }

        public void createAPropertyManagementFee(PropertyManagementFee propertyManagementFee)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                PropertyManagementFee pmf = new PropertyManagementFee();
                pmf.Amount = propertyManagementFee.Amount;
                pmf.From = propertyManagementFee.From;
                pmf.To = propertyManagementFee.To;

                pmsdbe.PropertyManagementFees.Add(pmf);
                pmsdbe.SaveChanges();
            }
        }

        public void deleteAPropertyManagementFee(int id)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var propertyManagementFeeRow = (from p in pmsdbe.PropertyManagementFees where p.Id == id select p).First();
                pmsdbe.PropertyManagementFees.Remove(propertyManagementFeeRow);
                pmsdbe.SaveChanges();
            }
        }

        public Complaint getComplaintById(int id)
        {
            Complaint complaint = new Complaint();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var complaintRow = from p in pmsdbe.Complaints where p.Id == id select p;
                if (complaintRow.Count() != 0)
                {
                    complaint.Id = complaintRow.First().Id;
                    complaint.Content = complaintRow.First().Content;
                    complaint.DateTime = complaintRow.First().DateTime;
                    complaint.PropertyOwnerId = complaintRow.First().PropertyOwnerId;
                }
            }
            return complaint;
        }

        public List<Complaint> getAllComplaints()
        {
            List<Complaint> complaints = new List<Complaint>();
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var complaintRows = from p in pmsdbe.Complaints select p;
                foreach (Complaint complaintRow in complaintRows)
                {
                    Complaint complaint = new Complaint();
                    complaint.Id = complaintRow.Id;
                    complaint.Content = complaintRow.Content;
                    complaint.DateTime = complaintRow.DateTime;
                    complaint.PropertyOwnerId = complaintRow.PropertyOwnerId;
                    complaints.Add(complaint);
                }
            }
            return complaints;
        }

        public void updateAComplaint(Complaint complaint)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var c = (from p in pmsdbe.Complaints where p.Id == complaint.Id select p).First();

                c.Content = complaint.Content;
                c.DateTime = complaint.DateTime;
                c.PropertyOwnerId = complaint.PropertyOwnerId;

                pmsdbe.SaveChanges();
            }
        }

        public void createAComplaint(Complaint complaint)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                Complaint c = new Complaint();
                c.Content = complaint.Content;
                c.DateTime = complaint.DateTime;
                c.PropertyOwnerId = complaint.PropertyOwnerId;

                pmsdbe.Complaints.Add(c);
                pmsdbe.SaveChanges();
            }
        }

        public void deleteAComplaint(int id)
        {
            using (PropertyManagementSystemDBEntities pmsdbe = new PropertyManagementSystemDBEntities())
            {
                var complaintRow = (from p in pmsdbe.Complaints where p.Id == id select p).First();
                pmsdbe.Complaints.Remove(complaintRow);
                pmsdbe.SaveChanges();
            }
        }
    }
}
