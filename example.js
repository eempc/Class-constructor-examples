function Cat (first, last, breed) {
  this.firstName = first;
  this.lastName = last;
  this.catBreed = breed;
  fullName : function() { return this.firstName + " " + this.lastName; }
}

var Mittens = new Cat("Mittens", "the Kitten", "Calico");
