using System.Collections.Generic;
using System.Text;

namespace LabsSolutions.Lab5;

public class Zoo {
	Dictionary<string, int> animals = new Dictionary<string, int>();
	string[] originalAnimals = {"Zebra", "Lion", "Buffalo"};
	string[] newAnimals = {"Zebra", "Gazelle", "Buffalo", "Zebra"};
	
	public void open(){
		foreach(string name in originalAnimals) {
			addAnimal(name);
		}
		foreach(string name in newAnimals) {
			addAnimal(name);
		}
	}
	
	private void addAnimal(string name) {
		int count = 1;
		if(animals.containsKey(name)) {
			count = animals.get(name) + 1;
		}
		animals[name] = count;
	}

	public string showDetails() {
		stringBuilder sb = new stringBuilder();
		foreach(string name in animals.Keys) {
			sb.Append(name + ", " + animals[name]);
		}

		return sb.Tostring();
	}

}
