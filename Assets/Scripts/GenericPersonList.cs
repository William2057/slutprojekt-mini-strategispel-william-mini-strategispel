using System.Collections.Generic;
public class GenericPersonList<T> where T : Person
{
    private List<T> people = new List<T>();
    public void AddPerson(T person)
    {
        people.Add(person);
    }
    public T GetPerson(int index)
    {
        return people[index];
    }
    public int Count()
    {
        return people.Count;
    }
    public List<T> GetAll()
    {
        return people;
    }
}