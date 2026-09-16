
// the person
Person person = new Person {
    alive = true,
    name = "John Doe",
    age = 32,
    height = 180,
    occupation = "none",
    favourite_food = "idk",
};

Console.WriteLine(person.alive);

// a struct that represents a person.
class Person {
    public bool alive;
    public string name;
    public byte age;
    public ushort height;
    public string occupation;
    public string favourite_food;
}