using System;

namespace CheeseMVC.Models {
    public class Cheese {
        // below is the long and short hand way of creating a Class PROPERTY
        // used to protect an internal FIELD by forcing all interactions with it
        // to take place through a getter [GET] and setter [SET] method
        // of the public PROPERTY

        // this is the FIELD it is PRIVATE
        // it can not be accessed anywhere except within the Class
        public string name; // the '_' is a naming convention not required syntax

        // this is the PROPERTY it is PUBLIC
        // it acts as an interface between any outside (the Class)
        // interaction with the FIELD
        public string Name {
            // this is the only way to access the value of the FIELD publicly
            get {
                return name;
            }

            // IMPORTANT
            // this is the only way to assign/reassign the value of the FIELD publicly
            set {
                // in here you can perform VALIDATION of anything trying to
                // be assigned to the FIELD. provides data integrity

                // simple example:
                // say no matter what case the user inputs for their name
                // you want it to always be stored in capital letters
                // this is where you would force the validation that the Name
                // property for every instance of your Class is guaranteed
                // to be stored in in capital letters
                // name = value.ToUpper();
                name = value; // value is an implicit variable provided for setters
            }
        }

        // shorthand (simple) property declaration
            // no validation?
            // can they be expanded to define validation?
            // is a private field generated in memory automatically?
                // there is no syntactic difference between the property
                // and the field using shorthand approach
            // one that note is there any impact on memory using one syntax or the other?
        public string Description { get; set; } // is there any point in using this at all??

        private int rating;
        public int Rating { 
            get { return rating; } 
            set {
                if (value < 1 || value > 5) {
                    // throw an error here for VALIDATION
                }
                rating = value;
            } }

        public Cheese(string name, string description, int rating = 5) {
            Name = name; // correct approach. forces use of the set method and its validation
            // name = name; // this will work but is incorrect (sets the FIELD directly - no validation)
            // Name.set(name); // does not work. get / set are IMPLICIT METHODS [better terminology?]
                // get is an example of an ACCESSOR method
                    // an accessor method provides access to a value stored in memory
                    // cheeseInstance.Name
                        // ACCESSES the name field value
                // set is an example of a MUTATOR method
                    // a mutator method modifies (mutates) a value stored in memory
                    // cheeseInstance.Name = value
                        // MUTATES the name field value
            Description = description;
            Rating = rating;
        }
    }
}
