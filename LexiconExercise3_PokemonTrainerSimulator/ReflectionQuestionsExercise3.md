# ❓ Reflection Questions

Answer the following questions based on the code you’ve written and tested:

### **1:** When you create a Pokémon and try to access its fields directly – does it work? Why or why not?
- __No__, in my solution, the fields are not accessible from outside the class. 
- The reason for that is that they are set as `private` which restricts direct access to those fields. 
Instead, they are accessible through their `Properties`, allowing the values to be set or read. The exception for this is `Type` property, which only has a get accessor, meaning that the value can only be read.

### **2:** If you later want to add a new property that applies to all Electric-type Pokémon, where should you place it to avoid repetition?
- If the new property only applies to electric Pokémon, then it should be placed in the class `ElectricPokemon`. 
- The reasoning behind the choice is that if it was placed in `Pokemon` then it would apply for all Pokémon, and if it was placed on the ``individual electric Pokémon`` then it would need to be repeated in every instance of electric Pokémon. 

### **3:** If instead the new property should apply to all Pokémon, where would be the correct place to define it?
- As stated in the answer for question 2, if the new property should apply for all Pokémon, then it should be placed in the base class `Pokemon`.

### **4:** What happens if you try to add a Charmander to a list that only allows `WaterPokemon`?
- The IDE will not allow you to do that and it will result in an error.
- The reason for this is that even though they inherit from the same abstract class `Pokemon`, they are not the same type. 
- To put it simply both have an Is A relationship with `Pokemon`, but they do not share an Is A relationship with each other. `Charmander` Is A `FirePokemon` while the list expect only `WaterPokemon`. 

### **5:** You want to store different types of Pokémon – Charmander, Squirtle, and Pikachu – in the same list. What type should the list have for that to work?
- The list should be of type `Pokemon`.
- As stated before the one class that all inherit from is `Pokemon`. They all have an Is A relationship with `Pokemon`, but not with any other type.

### **6:** When you loop through the list and call `Attack()`, what ensures that the correct attack behavior is executed for each Pokémon?
- With inheritance and polymorphisms the most specialized version of a method is chosen when it is executed. This means that if a method is overridden in a derived class, then the derived version of the method will be executed.
- In this this exercise we have the `Attack();` method in the `Pokemon` abstract class, and no overriding of the method in the derived classes. Therefore that method will always execute.
- Say however that we had overridden the `Attack();` method in ``Fire``, ``Water``, and ``ElectricPokemon`` classes then those would have a more specialized version and thus that version would be executed.   

### **7:** If you create a method that only exists on Pikachu, why can’t you call it directly when it’s stored in a `List<Pokemon>`? How could you still access it?
- If you think of inheritance in terms of humans. Then the base class is first generation of humans. The first generation has a set of knowledge and passes said knowledge their children. 
Their children thus now have the same knowledge as Their parent. When/If the children have new knowledge, They will pass it on to their children, but not to its parent. 
Therefore the third generation will have knowledge that the first generation does not have. 
- In this case, the `Pokemon` class is like the first generation of humans, and because the `Pikachu` class is treated as a `Pokemon` type while in the list, it will not be aware 
of any "knowledge" outside of the `Pokemon` class.
- To access said method you must cast the `Pokemon`-"Pikachu" type to the `Pikachu` class. it can be done amongst other ways with the `is` keyword, like this:

```csharp
if (Pokemon is Pikachu pikachu)
{
   pikachu.SomePikachuMethod();
}
```