import java.util.Arrays;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		int[] sayilar = new int[3];

		System.out.print("1. Sayıyı giriniz: ");
		sayilar[0] = input.nextInt();
		System.out.print("2. Sayıyı giriniz: ");
		sayilar[1] = input.nextInt();
		System.out.print("3. Sayıyı giriniz: ");
		sayilar[2] = input.nextInt();

		Arrays.sort(sayilar);

		System.out.println("Küçükten Büyüğe: ");
		for (int s : sayilar) {
			System.out.println(s);
		}

	}
}
