import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		int sicaklik = 0;

		Scanner input = new Scanner(System.in);
		System.out.print("Sıcaklık değerini giriniz: ");
		sicaklik = input.nextInt();

		if (sicaklik >= 25) {
			System.out.println("Yüzme");
		} else if (sicaklik >= 15) {
			System.out.println("Piknik");
		} else if (sicaklik >= 5) {
			System.out.println("Sinema");
		} else {
			System.out.println("Kayak");
		}
		input.close();
	}
}
