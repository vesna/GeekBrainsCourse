package Java_Homeworks.Seminar03;

import java.util.ArrayList;

/*Заполнить список названиями планет Солнечной системы в произвольном порядке с повторениями. 
Вывести название каждой планеты и количество его повторений в списке.
 */
public class Task02 {
    public static void main(String[] args) {
        ArrayList<String> planets = new ArrayList<>();
        planets.add("Марс");
        planets.add("Венера");
        planets.add("Земля");
        planets.add("Юпитер");
        planets.add("Земля");
        planets.add("Марс");
        planets.add("Юпитер");

        ArrayList<String> uniqPlanets = new ArrayList<>();
        ArrayList<Integer> counts = new ArrayList<>();
        CountRepeates(planets, uniqPlanets, counts);
        Print(uniqPlanets, counts);
    }

    private static void CountRepeates(ArrayList<String> planets, ArrayList<String> uniqPlanets,ArrayList<Integer> counts){
        for (String planet : planets) {
            int pos = uniqPlanets.indexOf(planet);
            if(pos >= 0){
                counts.set(pos, counts.get(pos) + 1);
                
            }
            else{
                uniqPlanets.add(planet);
                counts.add(1);
            }
        }
    }
    private static void Print(ArrayList<String> uniqPlanets,ArrayList<Integer> counts){
        for(int i = 0; i < uniqPlanets.size(); i++){
            System.out.printf("%-10s %3d \n", uniqPlanets.get(i), counts.get(i));
            
        }
    }
    
}
