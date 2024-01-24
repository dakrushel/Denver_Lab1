using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_Lab1
{
    public class Relation
    {
        private string relationshipType = "No relation";
        private List<object> familyMembers = new List<object>();

        public Relation (Person fMember1, Person fMember2, string relation)
        {
            this.familyMembers.Add(fMember1);
            this.familyMembers.Add(fMember2);
            this.relationshipType = relation;
            //Console.WriteLine($"The relation between {fMember1.firstName} and {fMember2.firstName} has been set to {relationshipType}.");
        }

        public string ShowRelationship(Person person1, Person person2)
        {
            if (familyMembers.Contains(person1) && familyMembers.Contains(person2))
            {
                return $"The relation between {person1.firstName} and {person2.firstName} is: {relationshipType}.";
            } else
            {
                return $"There is no relation between {person1} and {person2}.";
            }
        }
    }
}
