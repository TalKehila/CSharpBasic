class program
{
    static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>();
        //Pet mypet1 = new Pet("Bazilili");
        Pet mypet2 = new Pet("Chad");
        Pet mypet3 = new Pet("NINI");

        pets.Add(new Pet("Bazilili"));//same way 
        pets.Add(mypet2);
        pets.Add(mypet3);

        foreach (Pet pet in pets)
            Console.WriteLine(pet.name);


        Console.ReadKey();
    }
    class Pet
    {
        public string name;

        public Pet (string name)
        {
            this.name = name;   
        }
        public override string ToString()
        {
            return name; 
        }





    }





}