using System;
using System.Collections.Generic;
using System.Linq;

namespace TT_hoby.HashingOperations
{
  public class HashingOperations
  {
    private Dictionary<int, List<Contact>> _contacts = new Dictionary<int, List<Contact>>();

    public bool AddContact(string fullName, string phoneNumber)
    {
      if (_contacts.Any(contacts => contacts.Value.Any(contact => contact.PhoneNumber == phoneNumber)))
      {
        Console.WriteLine("Error: this number already exist");
        return false;
      }

      int hashKey = GenerateHashKey(fullName);
      if (_contacts.ContainsKey(hashKey))
      {
        bool contactExists = _contacts[hashKey]
          .Any(contact => contact.FullName == fullName && contact.PhoneNumber == phoneNumber);
        if (!contactExists) _contacts[hashKey].Add(new Contact { FullName = fullName, PhoneNumber = phoneNumber });
      }
      else _contacts[hashKey] = new List<Contact> { new Contact { FullName = fullName, PhoneNumber = phoneNumber } };

      return true;
    }

    public void RemoveContact(string fullName, string phoneNumber)
    {
      int hashKey = GenerateHashKey(fullName);
      if (_contacts.ContainsKey(hashKey))
        _contacts[hashKey].RemoveAll(x => x.FullName == fullName && x.PhoneNumber == phoneNumber);
    }

    public void EditContact(string name, string phone, string newFullName, string newPhoneNumber)
    {
      bool isAdded = AddContact(newFullName, newPhoneNumber);
      if (isAdded) RemoveContact(name, phone);
    }

    public void FindContactPhoneNumber(string name)
    {
      int hashKey = GenerateHashKey(name);
      if (_contacts.ContainsKey(hashKey))
        foreach (Contact contact in _contacts[hashKey].Where(contact => contact.FullName == name))
          Console.WriteLine($"Full name: {contact.FullName}, phone number: {contact.PhoneNumber}");
      else Console.WriteLine("Error: contact not found");
    }

    public void ShowAllContacts()
    {
      foreach (Contact contact in _contacts.SelectMany(contacts => contacts.Value))
        Console.WriteLine($"Full name: {contact.FullName}, phone number: {contact.PhoneNumber}");
    }

    public void RemoveAllContacts() => _contacts.Clear();

    private int GenerateHashKey(string input) => input.Aggregate(0, (current, c) => current + c);
  }
}