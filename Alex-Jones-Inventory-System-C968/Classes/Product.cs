using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexJonesInventorySystem.Classes
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; } 


        //add part to Binding List
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partSearchId)
        {
            for(int i = 0; i < AssociatedParts.Count(); i++)
            {
                if (AssociatedParts[i].PartID == partSearchId)
                {
                    AssociatedParts.Remove(AssociatedParts[i]);
                    return true;
                }
            }
            return false;
        }

        public Part LookupAssociatePart(int PartId)
        {
            foreach(Part p in AssociatedParts)
            {
                if (p.PartID == PartId)
                {
                    return p;
                }
            }
            Inhouse emptyPart = new Inhouse();
            return emptyPart;
        }
    }
}
