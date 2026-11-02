public class Main {
    public static void main(String[] args) {
        // RF-01: Array inicial com 4 times
        String[] times = {"Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova"};

        System.out.println("RF-01: Exibir os times");
        for (int i = 0; i < times.length; i++) {
            System.out.println("Índice " + i + ": " + times[i]);
        }

        System.out.println("\nRF-02 e RF-03: Confrontos de Ida e Volta");
        int totalIdaVolta = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = 0; j < times.length; j++) {
                if (i == j) {
                    continue; // RF-03: Impede confronto contra o próprio time
                }
                System.out.println(times[i] + " x " + times[j]);
                totalIdaVolta++;
            }
        }
        System.out.println("Total de confrontos (ida e volta): " + totalIdaVolta); // RF-04

        System.out.println("\nRF-05 e RF-06: Turno Único");
        int totalTurnoUnico = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = i + 1; j < times.length; j++) {
                System.out.println(times[i] + " x " + times[j]);
                totalTurnoUnico++;
            }
        }
        System.out.println("Total de confrontos (turno único): " + totalTurnoUnico); // RF-06

        System.out.println("\nETAPA 4: Inclusão do 5º time (Tombense) em Java");
        String[] novoArray = new String[5];
        for (int i = 0; i < times.length; i++) {
            novoArray[i] = times[i];
        }
        novoArray[4] = "Tombense";
        times = novoArray;

        System.out.println("Times atualizados com sucesso! Nova quantidade: " + times.length);
    }
}