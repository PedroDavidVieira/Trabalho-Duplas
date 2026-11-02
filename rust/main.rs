fn main() {
    // RF-01: Vec inicial com 4 times
    let mut times: Vec<String> = vec![
        String::from("Atlético-MG"),
        String::from("Cruzeiro"),
        String::from("América-MG"),
        String::from("Villa Nova"),
    ];

    println!("RF-01: Exibir os times");
    for (i, time) in times.iter().enumerate() {
        println!("Índice {}: {}", i, time);
    }

    println!("\nRF-02 e RF-03: Confrontos de Ida e Volta");
    let mut total_ida_volta = 0;
    for i in 0..times.len() {
        for j in 0..times.len() {
            if i == j {
                continue; // RF-03
            }
            println!("{} x {}", times[i], times[j]);
            total_ida_volta += 1;
        }
    }
    println!("Total de confrontos (ida e volta): {}", total_ida_volta); // RF-04

    println!("\nRF-05 e RF-06: Turno Único");
    let mut total_turno_unico = 0;
    for i in 0..times.len() {
        for j in (i + 1)..times.len() {
            println!("{} x {}", times[i], times[j]);
            total_turno_unico += 1;
        }
    }
    println!("Total de confrontos (turno único): {}", total_turno_unico); // RF-06

    println!("\nETAPA 4: Inclusão do 5º time (Tombense) em Rust");
    times.push(String::from("Tombense"));
    println!("Times atualizados com sucesso! Nova quantidade: {}", times.len());
}
