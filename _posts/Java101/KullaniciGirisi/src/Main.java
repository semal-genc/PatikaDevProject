import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		String userName, password;
		Scanner input = new Scanner(System.in);

		System.out.print("Kullanıcı adınız: ");
		userName = input.nextLine();
		System.out.print("Şifreniz: ");
		password = input.nextLine();

		if (userName.equals("Semal") && password.equals("semal1"))
			System.out.println("Hoş Geldiniz!");
		else if (userName.equals("Semal")) {
			if (!password.equals("semal1")) {
				System.out.println("Şifre yanlış!");
				System.out.print("Şifrenizi sıfırlamak istiyor musunuz? y/n: ");
				String select = input.nextLine();

				if (select.equals("y")) {
					System.out.print("Yeni şifrenizi girin: ");
					String newPassword = input.nextLine();

					if (newPassword.equals("semal1"))
						System.out.println("Şifre oluşturulamadı, lütfen başka şifre giriniz.");
					else
						System.out.println("Şifre oluşturuldu");
				} else if (select.equals("n"))
					System.out.println("Programdan çıkılıyor.");
				else
					System.out.println("Hatalı Seçim!");
			} else
				System.out.println("Hoş Geldiniz!");
		} else
			System.out.println("Kullanıcı adı ve şifre yanlış!");
	}
}
