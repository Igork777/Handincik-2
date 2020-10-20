using System.Collections.Generic;

namespace Hand_In_2.Data.Model
{
    public class Child : Person
    {
         
        public List<ChildInterest> ChildInterests { get; set; }
        public List<Pet> Pets { get; set; }

        public void Update(Child toUpdate) {
            base.Update(toUpdate);
            ChildInterests = toUpdate.ChildInterests;
            Pets = toUpdate.Pets;
        }

    }
}