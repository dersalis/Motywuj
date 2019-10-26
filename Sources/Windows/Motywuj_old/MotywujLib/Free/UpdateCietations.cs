using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Atrx.WindowsPhone.Motywuj;

namespace Atrx.WindowsPhone.Motywuj.Free
{
	public class UpdateCietations
	{

		#region PIERWSZE URUCHOMIENIE PROGRAMU

		//
		// Dodaje cytaty przy pierwszym uruchomieniu programu
		//
		public static bool AddCitationsToBaseFirstStart(CitationDataContext db)
		{
			// Określa poprawność zapisu w bazie
			bool isCorrectly = false;
			// Dodaj cytaty
			db.Citations.InsertOnSubmit(new Citation() { Content = "Życie to dziesięciobiegowy rower. Większość z nas ma biegi, których nigdy nie używa.", Author = "Charles Schultz", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Jedynym, co ogranicza siłę, są więzy wiary.", Author = "Harold Wilson", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Co należy zrobić po upadku? To, co robią dzieci: podnieść się.", Author = "Aldous Huxley", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Zwycięska postawa polega na byciu fizycznie rozluźnionym i mentalnie spiętym.", Author = "Arthur Robert Ashe, Jr.", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Powiedz komuś, że jest odważny, a pomożesz mu stać się takim.", Author = "Thomas Carlyle ", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Każde działanie podjęte bez planu kryje zalążek wszelkiego niepowodzenia.", Author = "Alex MacKenzie", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Dlaczego nie ryzykować chodząc po drzewach? Przecież to na nich rosną owoce!", Author = "Mark Twain", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Najtrudniejsze w sukcesie jest to, że nie można na jego odniesieniu poprzestać. Talent w biznesie to tylko punkt wyjściowy. Cały czas trzeba gonić go do roboty.", Author = "Irving Beriln", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Na co przyda się wspinanie po drabinie sukcesu, jeżeli u celu okaże się, że opiera się ona o niewłaściwy budynek?", Author = "James Dobson", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Istnieje na tym świecie wielu ludzi, którzy spędzają tyle czasu dbając o zdrowie, że nie mają czasu, by się nim cieszyć.", Author = "Josh Billings", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Tajemnica szczęścia nie leży w większym posiadaniu, ale w umiejętności cieszenia się mniejszym posiadaniem.", Author = "Sokrates", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Największym zagrożeniem dla większości z nas nie jest to, że postawimy sobie za wysoki cel i nie osiągniemy go, ale że postawimy sobie za mały cel i osiągniemy go.", Author = "Michał Anioł", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Nie ma większego nieszczęścia nad uleganie pożądaniom i większego przewinienia nad nienasycenie.", Author = "Laozi", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Nie ma większej katastrofy niż wtedy, gdy ktoś nie potrafi się zadowolić tym, co posiada.", Author = "Laozi", IsFavorite = false });
			db.Citations.InsertOnSubmit(new Citation() { Content = "Aby patrzeć inaczej na świat, najpierw spójrz na człowieka w lustrze.", Author = "Michael Jackson", IsFavorite = false });

            db.Citations.InsertOnSubmit(new Citation() { Content = "Wielu chce żyć i nie starzeć się, a w rzeczywistości starzeją się i nie żyją.", Author = "Alexander Mitscherlich", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Sukces jest zdolnością do przejścia od jednej porażki do drugiej bez utraty entuzjazmu.", Author = "Winston Churchill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Problem to okazja w przebraniu.", Author = "John Adams", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli potrafisz powiedzieć, kim są Twoi bohaterowie, będę mógł powiedzieć, co osiągniesz w życiu.", Author = "Warren Buffet", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przyroda nie spieszy się, a jednak ze wszystkim nadąża.", Author = "Laozi", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Błąd łatwiej można dostrzec niż prawdę, bo błąd leży na wierzchu, a prawda w głębi.", Author = "Johann Wolfgang von Goethe", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Oko widzi tylko to, co umysł gotowy jest przyjąć.", Author = "Henri Bergson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bycie najbogatszym człowiekiem na cmentarzu nie ma dla mnie znaczenia... Kiedy w nocy kładę się spać mówiąc, że stworzyliśmy coś wspaniałego... To jest to, co ma dla mnie znaczenie.", Author = "Steve Jobs ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Gdy osądzasz innych - nie pokazujesz jakimi oni są - pokazujesz jaki Ty jesteś", Author = "Wayne Dyer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jesteś urodzony, by zwyciężać, jednakże, aby być zwycięzcą musisz zaplanować zwycięstwo, przygotować się do zwycięstwa i oczekiwać zwycięstwa.", Author = "Zig Ziglar", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeżeli istnieje sposób, by zrobić coś lepiej... znajdę go.", Author = "Thomas Edison ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najlepszy sposób osiągnięcia szczęścia - to rozsiewanie go wokół siebie.", Author = "Robert Baden-Powell", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "To nie to, co masz, ani to, kim jesteś, ani to, gdzie jesteś, ani co robisz czyni Cię szczęśliwym bądź nieszczęśliwym. Chodzi o to, o czym myślisz.", Author = "Dale Carnegie", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najpierw postaraj się być wartościowym człowiekiem, sukces nadejdzie sam.", Author = "Albert Einstein", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Większość domów wartych powyżej $250.000 ma bibliotekę, przemyśl to.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Szaleństwem jest zachowywać się w ten sam sposób i oczekiwać innego rezultatu.", Author = "Albert Einstein", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ciesz się każdą chwilą, abyś potem nigdy nie żałował, że utraciłeś młodość.", Author = "Paulo Coelho", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Sukces jest czymś, co przyciągasz poprzez to, kim się stajesz.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wielkie umysły mają cele. Małe umysły mają życzenia.", Author = "Washington Irving ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najlepszą metodą przewidywania przyszłości jest jej tworzenie.", Author = "Peter Drucker", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli jesteś dobrą piłką, to im silniej cię uderzą, tym wyżej się wzniesiesz.", Author = "Tristan Bernard ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie potrzebujesz bardziej kreatywnych rozwiązań, potrzebujesz bardziej kreatywnych pytań.", Author = "Andy Green ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Podróż tysiąca mil zaczyna się od jednego kroku.", Author = "Konfucjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pamiętaj, iż twoja własna determinacja, by osiągnąć sukces, liczy się bardziej, niż cokolwiek innego na świecie.", Author = "Abraham Lincoln ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Działaj, jakby to, co robisz czyniło różnicę. Bo czyni.", Author = "William James", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Każdy głupi potrafi krytykować, potępiać i narzekać, ale potrzeba charakteru i samokontroli, by być rozumiejącym i przebaczającym.", Author = "Dale Carnegie", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wyzwania stawiane Ci przez życie nie mają Cię sparaliżować - one mają pomóc Ci odkryć, kim jesteś.", Author = "Bernice Johnson Reagon", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie ma takiej fantazji, której wola i rozum ludzki nie zdołałyby przekształcić w rzeczywistość.", Author = "William Szekspir ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Chcąc zmusić ludzi, aby dobrze o nas mówili, jedyny to sposób - czynić dobrze.", Author = "Voltaire", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeżeli coś ci się nie uda, możesz być rozczarowany. Jeżeli jednak nie będziesz dalej próbować, już po tobie.", Author = "Beverly Sills", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "O radę pytaj tego, kto sam sobie radzi.", Author = "Leonardo da Vinci", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie starzeje się ten, kto nie ma na to czasu.", Author = "Benjamin Franklin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nic tak nie przyczynia się do szybkiego sukcesu jak cudze błędy.", Author = "Roger Bacon", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Stojący w porcie statek jest bezpieczny, ale statków nie buduje się po to aby stały w portach.", Author = "Grace Hopper ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Twoim celem musi być zdobycie wszystkiego bez zniszczenia czegokolwiek.", Author = "Sun Tzu ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Prawdziwa podróż ku odkryciu składa się nie z poszukiwania nowych pejzaży, lecz obserwacji nowymi oczami.", Author = "Marcel Proust", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Żyj kierując się swoją wyobraźnią, nie swoją historią.", Author = "Stephen Covey ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jedyną rzeczą, która jest jednakowa na całym świecie jest ilość godzin na dobę. Różnica między wygrywaniem a przegrywaniem tkwi w tym, co robisz z tymi godzinami.", Author = "Woody Hayes", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli nie ustalasz celów dla siebie, jesteś skazany na pracowanie przy osiąganiu celów kogoś innego.", Author = "Brian Tracy", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Działanie jest podstawowym kluczem do każdego sukcesu.", Author = "Pablo Picasso", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Poświęcaj tyle czasu na ulepszanie siebie, byś nie miał go na krytykę innych.", Author = "Christian D. Larson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Co ważniejsze dla sukcesu: talent czy pracowitość? A co ważniejsze w rowerze: przednie czy tylne koło?", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jak blask słońca oświetla wnętrze komnaty, tak nauka rozświetla umysł.", Author = "Wang Chong ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie pozwól obawie o to, ile zajmie osiągnięcie czegoś, przeszkodzić Ci w robieniu tego. Czas i tak upłynie, a możemy równie dobrze wykorzystać go w najlepszy możliwy sposób.", Author = "Earl Nightingale", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Gdyby ludzie wiedzieli, jak ciężko pracowałem, aby osiągnąć swe mistrzostwo, wcale nie wydawałoby im się tak cudowne.", Author = "Michał Anioł ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ludzie w większości przypadków poddają się wówczas, gdy są już na progu zwycięstwa. Rezygnują tuż przed metą. W ostatniej minucie gry, na metr przed linią, za którą jest zwycięstwo.", Author = "Ross Perot", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Życie jest ciągiem doświadczeń, z których każde czyni nas silniejszymi, mimo że czasem trudno nam to sobie uświadomić.", Author = "Henry Ford ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeden siedzi dziś w cieniu dlatego, że inny dawno temu posadził w tym miejscu drzewo.", Author = "Warren Buffet ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Co wieczór stawiać sobie poważnie pytanie, czegośmy się w danym dniu nowego nauczyli.", Author = "Georg Christoph Lichtenberg ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Mądry jest nie ten, który martwi się z powodu niedostatku, lecz ten, który cieszy się z tego, co ma.", Author = "Demokryt ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Odpowiedzialni jesteśmy nie tylko za to, co robimy, lecz i za to, czego nie robimy.", Author = "Lao - Tse", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bardziej niż cokolwiek innego - przygotowywanie się jest sekretem do sukcesu.", Author = "Henry Ford", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Można rozpalić nowy ogień, lecz nie sposób wskrzesić ognia raz ugaszonego.", Author = "Wang Chong", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek powinien sięgać po to, co przewyższa jego możliwości.", Author = "Robert Browning ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli z premedytacją planujesz, by nie wykorzystać w pełni swojego potencjału - muszę Cię ostrzec - będziesz nieszczęśliwy do końca swoich dni.", Author = "Abraham Maslow ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przeszkody pojawiają się, gdy spuszczasz wzrok z celu.", Author = "Hannah More ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Cieśla, który chce dobrze robotę wykonać, musi wpierw naostrzyć swe narzędzia.", Author = "Konfucjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Cnotę widać wyraźniej w czynach niż w ich braku.", Author = "Arystoteles", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie czekaj. Pora nigdy nie będzie idealna!", Author = "Napoleon Hill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najważniejszym powodem, dla którego ludzie nie osiągają tego, co chcą, jest to, że sami nie wiedzą, czego chcą.", Author = "T. Harv Eker", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nikt nie jest w stanie sprawić, byś poczuł się gorszym, bez Twojego pozwolenia.", Author = "Eleanor Roosevelt", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czytanie dobrych książek jest niczym rozmowa z najwspanialszymi ludźmi.", Author = "Kartezjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jesteśmy jak żeglarze, którzy muszą swój żaglowiec przebudować na otwartym morzu, a nie mogą go nigdy położyć w doku i zbudować od nowa z najlepszych części.", Author = "Otto Neurath", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bądź wierny sobie, a nie będziesz niewierny innym.", Author = "Francis Bacon", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Biednym jest nie ten, kto ma mało, ale ten, kto tęskni za tym, by mieć więcej.", Author = "Seneka", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Tylko ta praca daje siły, która i sił wymaga.", Author = "Władysław Grzeszczyk ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Chcąc doznać pełni szczęścia, trzeba je dzielić z kimś drugim.", Author = "Mark Twain ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Lepiej spłonąć niż zwiędnąć.", Author = "Aleksander Wielki", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Geniusz to czasem tylko instynkt, który nie podlega doskonaleniu; częściej jest to sztuka trafnego kojarzenia codziennie doskonalona dzięki obserwacji i doświadczeniu.", Author = "Napoleon Bonaparte", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jest tylko jeden sposób nauki. Poprzez działanie.", Author = "Paulo Coelho ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Widzicie różne rzeczy i pytacie: dlaczego takie są? Natomiast ja marzę o rzeczach, których nie ma i pytam: dlaczego by nie miały zaistnieć?", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Największym zwycięstwem jest to, które odnosimy nad nami samymi.", Author = "Tadeusz Kościuszko", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kochasz życie? Nie trwoń zatem swego czasu, ponieważ ono jest z niego utkane.", Author = "Benjamin Franklin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie ma żadnego usprawiedliwienia, by nie stać się wielkim.", Author = "Tom Peters ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Geniusz to wynik 1 procenta natchnienia i 99 procent wypocenia.", Author = "Thomas Edison", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wygrywa tylko ten, kto ma jasno określony cel i nieodparte pragnienie, aby go osiągnąć.", Author = "Napoleon Hill ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "W konfrontacji strumienia ze skałą, strumień zawsze wygrywa - nie przez swoją siłę, ale przez wytrwałość.", Author = "Budda", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek jest tym, o czym przez cały dzień myśli.", Author = "Ralph Waldo Emerson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Motywacja jest tym, co pozwala Ci zacząć. Nawyk jest tym, co pozwala Ci wytrwać.", Author = "Jim Ryun", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Życia nie mierzy się ilością oddechów, ale ilością chwil, które zapierają dech w piersiach.", Author = "Maya Angelon", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Całe nasze życie to działanie i pasja. Unikając zaangażowania w działania i pasje naszych czasów, ryzykujemy, że w ogóle nie zaznamy życia.", Author = "Herodot", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Twój los zależy od Twoich nawyków.", Author = "Brian Tracy ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Odważnym szczęście sprzyja.", Author = "Wergiliusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ludzie, którzy tracą czas czekając, aż zaistnieją najbardziej sprzyjające warunki, nigdy nic nie zdziałają. Najlepszy czas na działanie jest teraz!", Author = "Mark Fisher", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bądź zmianą, którą pragniesz ujrzeć w świecie.", Author = "Mahatma Gandhi", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przyszłość zaczyna się dzisiaj, nie jutro.", Author = "Jan Paweł II ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "By dojść do źródła, trzeba płynąć pod prąd.", Author = "Stanisław Jerzy Lec", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Im więcej mamy czasu na wykonanie jakiejś pracy, tym więcej czasu ona nam zabiera.", Author = "C. Northcote Parkinson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli sądzisz, że potrafisz to masz rację. Jeśli sądzisz, że nie potrafisz - również masz rację.", Author = "Henry Ford", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Musimy żeglować czasem z wiatrem, czasem pod wiatr, ale żeglować, nie dryfować ani stawać na kotwicy.", Author = "Oliver Wendell Holmes", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jesteśmy tym, co w swoim życiu powtarzamy. Doskonałość nie jest jednorazowym aktem, lecz nawykiem.", Author = "Arystoteles", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Potykając się, można zajść daleko; nie wolno tylko upaść i nie podnieść się.", Author = "Johann Wolfgang von Goethe ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Obie rzeczy - zarówno to, przed czym uciekasz, jak i to, za czym wzdychasz - są w tobie.", Author = "Anthony de Mello ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zakres szczęścia człowieka zależy od niego samego.", Author = "Abraham Lincoln", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Największe bogactwo, to robienie tego, co kochasz.", Author = "Colin P. Sisson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Poczucie humoru dobrze amortyzuje życiowe wstrząsy.", Author = "Phil Bosmans", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wielu ludzi jest nieszczęśliwych jedynie dlatego, że mają czas, aby zastanowić się nad tym, czy są szczęśliwi, czy też nie.", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nic nie jest szczególnie trudne do zrobienia, jeśli tylko rozłożyć to na etapy.", Author = "Henry Ford", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie staraj się zostać człowiekiem sukcesu, lecz człowiekiem wartościowym.", Author = "Albert Einstein ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Doskonałość jest miarą nieba, dążenie do doskonałości miarą człowieka.", Author = "Johann Wolfgang von Goethe ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeżeli twoje marzenia Cię nie przerażają - nie są wystarczająco duże.", Author = "Ellen Johnson Sirleaf ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Spędziłem większość życia, martwiąc się o rzeczy, które nigdy się nie wydarzyły.", Author = "Mark Twain", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek, który umie żyć w harmonii z samym sobą jest szczęśliwy.", Author = "Oscar Wilde", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nic, co ma wielką wartość w życiu, nie przychodzi łatwo.", Author = "Norman Vincent Peale", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ten, kto naprawdę umie żyć, zaczyna dzień od uśmiechu.", Author = "Thich Nhat Hanh ", IsFavorite = false });
            //db.Citations.InsertOnSubmit(new Citation() { Content = "", Author = "", IsFavorite = false });

			// Zapisz zmiany w bazie
			db.SubmitChanges();
			// Poprawnie zapisano
			isCorrectly = true;

			return isCorrectly;
		}

		#endregion


        #region AKTUALIZACJA 1.1.0.2

        public static void AddUpdate_1102(CitationDataContext db)
        {
            // Dodaj cytaty
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie wystarczy bystry umysł, trzeba jeszcze umieć z niego korzystać.", Author = "Kartezjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Odkładanie pełni życia, aż strach zniknie, jest bez sensu. Żal z powodu tego, co zrobiliśmy, czas złagodzi; to żal z powodu tego, czego nie zrobiliśmy, jest nie do złagodzenia.", Author = "Sydney J.Harris", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pamiętaj, że w tej samej chwili, kiedy mówisz: \"Poddaję się\", ktoś inny oceniając tę samą sytuację, mówi: \"O rany, ale okazja\".", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nigdy nie jest za późno, aby być tym, kim miałaś być.", Author = "George Eliot", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zaufaj sobie, a będziesz wiedział, jak żyć.", Author = "Johann Wolfgang von Goethe", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ludzie dostrzegają tylko to, na co są przygotowani.", Author = "Ralph Waldo Emerson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przeciętne umysły zwykle odrzucają to, czego nie mogą pojąć.", Author = "La Rochefoucauld", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Odpocznij. Pole, które odpoczęło daje obfite plony.", Author = "Publius Ovidius Naso", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Szczęście to to, czego prawdopodobnie w życiu nie osiągniemy, ale na jego szukanie warto poświęcić całe życie.", Author = "Stendhal", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Na szczęście gdzieś pomiędzy przypadkiem a tajemnicą znajduje się wyobraźnia, jedyna rzecz, która chroni naszą wolność, mimo tego, że ludzie starają się ją ograniczać albo całkiem zniszczyć.", Author = "Luis Bunuel", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Największy sekret szczęścia, to być w zgodzie z sobą…", Author = "Budda", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie liczy się to, czy przewidziałeś deszcz. Liczy się, czy zbudowałeś arkę. Noe nie czekał z budową arki, aż spadnie deszcz.", Author = "Warren Buffet", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Noc bardziej rozumie, lecz dzień więcej daje.", Author = "Władysław Grzeszczyk", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kiedykolwiek coś robisz, rób to tak, jakby cały świat na Ciebie patrzył.", Author = "Thomas Jefferson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "W systemie wartości człowieka nie ma nic ważniejszego - bardziej decydującego o jego rozwoju psychicznym i motywacjach - niż szacunek, którym darzy on samego siebie.", Author = "Nathaniel Branden", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Prawdziwymi zwycięzcami są ci, którzy zwyciężają w walkach życia codziennego.", Author = "Masutatsu Oyama", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Długoterminowe cele powodują, że nie frustrujesz się krótkoterminowymi porażkami.", Author = "James Cash Penney", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli żyjesz doceniając zbiegi okoliczności i ich znaczenie, łaczysz się z leżącym pod powierzchnią polem nieskończonych możliwości.", Author = "Deepak Chopra", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Za każdym razem, gdy czujesz się nieszczęśliwy, obecna jest też fantastyczna okazja, byś zrobił wielki krok naprzód.", Author = "Lester Levenson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najciężej w życiu ma ten, kto usiłuje unikać trudności.", Author = "Bolesław Prus", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Cokolwiek zamierzasz zrobić, o czymkolwiek marzysz, zacznij działać. Śmiałość zawiera w sobie geniusz, siłe i magię.", Author = "Johann Wolfgang von Goethe", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Problemem w moim życiu i w życiu innych ludzi nie jest brak wiedzy, co zrobić, ale brak robienia tego.", Author = "Peter Drucker", IsFavorite = false });
            //db.Citations.InsertOnSubmit(new Citation() { Content = "", Author = "", IsFavorite = false });

            // Zapisz zmiany w bazie
            db.SubmitChanges();

        }

        #endregion


        #region AKTUALIZACJA 1.1.1.2

        public static void AddUpdate_1112(CitationDataContext db)
        {
            // Dodaj cytaty
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bycie szczerym może nie da Ci zbyt wielu przyjaciół, ale zawsze da Ci tych właściwych.", Author = "John Lennon", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie pozwól, by dzień wczorajszy zajmował zbyt dużą część dnia dzisiejszego.", Author = "Will Rogers", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dobrze widzi się tylko sercem. Najważniejsze jest niewidoczne dla oczu.", Author = "Antoine de Saint-Exupéry", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie należy gniewać się na bieg wypadków, bo to ich nic nie obchodzi.", Author = "Marek Aureliusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Obie rzeczy - zarówno to, przed czym uciekasz, jak i to, za czym wzdychasz - są w tobie.", Author = "Anthony de Mello", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Prawda istnieje. Wymyśla się kłamstwo.", Author = "Georges Braque", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Za każdy dar łaski bądź wdzięczny, a większego staniesz się godny, bo wdzięczność za otrzymane łaski jest modlitwą o nowe.", Author = "Józef Sebastian Pelczar", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zwycięzcy robią to, czego przegranym się nie chciało.", Author = "H. Jackson Brown, Jr ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Denerwować się to znaczy mścić się na własnym zdrowiu za głupotę innych.", Author = "Ernest Hemingway", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Mądry człowiek więcej możliwości tworzy, niż znajduje.", Author = "Henry Ford", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Szczęście nie jest sprzymierzeńcem ludzi bezczynnych.", Author = "Sofokles", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli chcesz być tym, kim nie jesteś, to musisz być niezadowolony z tego, kim jesteś.", Author = "św. Augustyn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Świat, który cię otacza, to odbicie świata, który nosisz w sobie.", Author = "Brian Tracy ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto w drobnej rzeczy jest wierny, ten i w wielkiej będzie wierny; a kto w drobnej rzeczy jest nieuczciwy, ten i w wielkiej nieuczciwy będzie", Author = "Jezus Chrystus", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Twój los kształtuje się w momentach podejmowania decyzji.", Author = "Anthony Robbins", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli istnieje jakakolwiek pewna droga do sukcesu i spełnienia w życiu, to można ją odnaleźć w nieśpiesznym, pozbawionym doraźnych celów procesie samodoskonalenia.", Author = "George Leonard", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto myśli o problemach – ma problemy. Kto myśli o rozwiązaniach – ma rozwiązania.", Author = "Nikolaus B. Enkelmann", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli chcecie poznać ludzi wokół siebie, dowiedzcie się, co czytają.", Author = "Józef Stalin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Lepiej zaliczać się do niektórych, niż do wszystkich.", Author = "Andrzej Sapkowski", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Sukces jest wynikiem właściwej decyzji.", Author = "Eurypides", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Każdy ma swój własny Mount Everest, dla którego zdobycia pojawił się na ziemi.", Author = "Hugh Macleod ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Sukces zwykle przychodzi do tych, którzy są zbyt zajęci by go szukać.", Author = "Henry David Thoreau ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Chińskie słowo „kryzys” składa się z dwóch znaków: pierwszy oznacza zagrożenie, drugi możliwość.", Author = "John Fitzgerald Kennedy ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ten, kto wyciąga ręce w stronę gwiazd, chociaż ich nie dotknie, jednak z pewnością sięgnie poza korony drzew.", Author = "Bodo Schafer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nagrody dla potrafiących wytrwać znacznie przewyższają ból, który musi poprzedzać zwycięstwo.", Author = "Ted W. Engstrom", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Działaj, jakby każda osoba, którą spotykasz, miała na szyi napis „Spraw, bym poczuł się ważny”. Odniesiesz sukces nie tylko w sprzedaży, ale także w życiu.", Author = "Mary Kay Ash", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przypadki mają tendencję do kierowania się w stronę najbardziej dominujących myśli.", Author = "Ted W. Engstrom", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Niech inni prowadzę nieciekawe życie, ale nie ty. Niech inni spierają się o błahe rzeczy, ale nie ty. Niech inni płaczą na poczuciem krzywdy, ale nie ty. Niech inni pozostawiają swą przyszłość w rękach kogoś innego, ale nie ty.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przyjaźń jest najdelikatniejszym kwiatem, który rozwija się z wzajemnych kontaktów międzyludzkich. Jeżeli nie dbamy o niego cierpliwie i niestrudzenie, więdnie i usycha, zanim otworzy wszystkie swoje pączki.", Author = "Zenta Maurina Raudive ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pomysł, który masz, a którego nie wykorzystujesz, nie przyniesie efektów większych niż pomysł, którego nigdy nie miałeś i nie mogłeś wykorzystać.", Author = "Jim Collins ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Trudność życia polega na tym, aby rozróżnić, które mosty przekraczać, a które palić.", Author = "David Russell", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dopóki walczysz, jesteś zwycięzcą!", Author = "św. Augustyn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie ograniczaj się do bycia lepszym od rówieśników i poprzedników. Staraj się być lepszy od samego siebie.", Author = "William Faulkner ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nigdy niczego by nie spróbowano, gdyby trzeba było najpierw przezwyciężyć wszystkie możliwe obiekcje.", Author = "Samuel Johnson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zacznij od robienia tego, co konieczne; potem zrób to, co możliwe; nagle odkryjesz, że dokonałeś niemożliwego.", Author = "św. Franciszek z Asyżu ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Usuń ze swojego słownika słowo „problem” i zastąp słowem „wyzwanie”. Życie stanie się nagle bardziej podniecające i interesujące.", Author = "Albert Camus", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dużo lepiej jest zdobywać się na śmiałe czyny i dążyć do triumfu w chwale, nawet kosztem porażek, niż snuć się wśród ludzi o ubogich duszach, którzy nie potrafią w pełni cieszyć się ani cierpieć, bo żyją w szarym cieniu, gdzie nie ma zwycięstw ani porażek.", Author = "Theodore Roosevelt", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek, który nie robi błędów, zwykle nie robi niczego.", Author = "Edward John Phelps", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Choć nikt nie może cofnąć się w czasie i zmienić początku na zupełnie inny, to każdy może zacząć dziś i stworzyć całkiem nowe zakończenie.", Author = "Carl Bard", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Mogę zaakceptować porażkę, ale nie mogę zaakceptować braku próby.", Author = "Michael Jordan", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Twoje założenia są twoimi oknami na świat. Wyszoruj je od czasu do czasu, inaczej nie przejdzie światło.", Author = "Isaac Asimov", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jakże szybko „nie teraz” staje się „nigdy”.", Author = "Martin Luter King", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czy zbudowałeś już swoje zamki w przestworzach? Doskonale, tam właśnie powinny stanąć. Teraz, natychmiast zabierz się do pracy i połóż pod nie fundamenty.", Author = "Henry David Thoreau", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie chodź tam, dokąd może zaprowadzić cię droga; zamiast tego idź tam, gdzie ścieżki nie ma w ogóle, i pozostaw za sobą szlak.", Author = "Ralph Waldo Emerson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli masz więcej niż 3 priorytety działania, to znaczy, że nie masz żadnego.", Author = "Jim Collins", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli nie umiesz latać, biegnij. Jeśli nie umiesz biegać, chodź. Jeśli nie umiesz chodzić, czołgaj się. Ale bez względu na wszystko – posuwaj się naprzód.", Author = "Martin Luter King", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Umysł, raz rozciągnięty przez nową ideę, nigdy nie powraca do swoich poprzednich rozmiarów.", Author = "Oliver Wendell Holmes ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wolę błąd entuzjasty od obojętności mędrca.", Author = "Anatole France", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Siła człowieka nie polega na tym, że nigdy nie upada, ale na tym, że potrafi się podnosić.", Author = "Konfucjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zamiast zastanawiać się, gdzie pojedziesz w następne wakacje, żyj życiem, od którego nie trzeba uciekać.", Author = "Seth Godin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Szczęście jest jak motyl; im bardziej go gonisz, tym bardziej ci ucieka, lecz gdy zwrócisz swoją uwagę ku innym rzeczom, przyfrunie i usiądzie łagodnie na twoim ramieniu.", Author = "Henry David Thoreau ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli szczęście osobiste staje się jednym celem życia, życie niebawem traci swój cel.", Author = "Anonim", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Każdy człowiek umiera, nie każdy naprawdę żyje.", Author = "William Wallace", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Aby odnieść w życiu sukces, trzeba czegoś więcej niż określenie podstawowych celów.", Author = "Vincent Clement-Stone", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Różnica pomiędzy ludźmi wspaniałymi a wszystkimi pozostałymi polega na tym, że wspaniali ludzie sami kują swój los, a pozostali przyjmują życie takim, jakim ono jest, czekając, co będzie dalej.", Author = "Michael E. Gerber", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najlepsza cześć życia ludzkiego to małe, bezimienne i zapomniane akty dobroci i miłości.", Author = "William Wordsworth", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Tak kochamy marzenia, że boimy się je realizować.", Author = "Albert Camus", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Z moich doświadczeń wynika, że kreatywnej pracy na najwyższym poziomie nie można wykonywać, gdy jest się nieszczęśliwym.", Author = "Albert Einstein", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Cnota nie jest niczym innym niż sztuka, jak być samemu szczęśliwym przez szczęście innych.", Author = "Jeremy Bentham", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Podstawowa różnica pomiędzy wojownikiem i zwykłym człowiekiem polega na tym, że cokolwiek się dzieje, wojownik uznaje to za wyzwanie, a zwykły człowiek - za błogosławieństwo albo za przekleństwo.", Author = "Carlos Castaneda", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kluczem do sukcesu jest skoncentrowanie umysłu na tym, czego pragniemy, nie na tym, czego się boimy.", Author = "Brian Tracy", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli spoczywasz na różach w młodości, ciernie będą Twoim łożem w starości.", Author = "Feliks Feldheim", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Świat należy do ludzi, którzy mają odwagę marzyć i ryzykować, aby spełniać swoje marzenia. I starają się robić to jak najlepiej.", Author = "Paulo Coelho", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Aby zdobyć wielkość, człowiek musi tworzyć, a nie odtworzyć.", Author = "Antoine de Saint-Exupéry", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie powstrzymuje Cię ani brak potencjału, ani brak okazji - powstrzymuje Cię brak pewności siebie.", Author = "Brian Tracy", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czas zmarnowany nie istnieje we wspomnieniach.", Author = "Stefan Kisielewski", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pewność siebie jest podstawą wszystkich wielkich dokonań i sukcesów.", Author = "Brian Tracey", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wznoś się po każdym upadku, padniesz trupem albo urosną Ci skrzydła.", Author = "Maria von Ebner-Eschenbach", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Cokolwiek umysł może wymyślić, to może osiągnąć.", Author = "Clement Stone", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie na tym rzecz polega, aby dodać lat do życia, ale na tym przede wszystkim, aby dodać życia do lat.", Author = "Alexis Carrel", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Motywacja jest tym co pozwala Ci zacząć. Nawyk jest tym co pozwala Ci wytrwać", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kiedy byłem młody zaobserwowałem, że dziewięć na dziesięć rzeczy, które robiłem okazywało się porażką, więc pracowałem dziesięć razy tyle.", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pozwól innym wieść małe życie, ale nie sobie. Pozwól innym kłócić się o nieistotne szczegóły, ale nie sobie. Pozwól innym płakać z byle powodu, ale nie sobie. Pozwól innym zostawić swoją przyszłość w czyichś rękach, ale nie sobie.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dużo ludzi nie wie, co z czasem robić. Czas nie ma z ludźmi tego kłopotu.", Author = "Magdalena Samozwaniec", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Gdybyś usłyszał tysiąc razy - nie uda Ci się. To wiesz co? Rób nadal wszystko jak najlepiej potrafisz i pokaż, jak bardzo się mylili. Sukces jest największą, dostępną, ludzką zemstą.", Author = "Nikodem Marszałek", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Strategia defensywna nigdy nie przyniosła ostatecznego zwycięstwa.", Author = "Douglas MacArthur", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek biedny to człowiek bez celu, bez możliwości nauki i bez chęci do zmian.", Author = "Nikodem Marszałek", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wiele tracimy wskutek tego, że przedwcześnie uznajemy coś za stracone.", Author = "Johann Wolfgang von Goethe", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wcześnie w życiu zrozumiałem, żeby być i mieć, trzeba najpierw pracować i chcieć.", Author = "Nikodem Marszałek", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Chowanie urazy, to jak picie trucizny w nadziei, że pozabija Twoich wrogów.", Author = "Nelson Mandela", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Mądrość ludzka zależy w mniejszym stopniu od nagromadzonego doświadczenia, w większym zaś od zdolności doświadczania.", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ile to czasu poświęcamy spaniu nad potrzebę? Zapominamy o tem, że lis śpiący nie złapie kuny, i że dosyć będziemy mieli czasu do spania, kiedy nas w grobie położą.", Author = "Benjamin Franklin ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto się zbliża, tego nie odpychajcie, kto odchodzi, tego nie zatrzymujcie. Kto wraca tego przyjmijcie, jakby się nigdy nie oddalał.", Author = "Johann Wolfgang von Goethe", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Idź swoją drogą, a ludzie niech mówią, co chcą.", Author = "Dante Alighieri", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "By dostać więcej od życia, dawaj więcej od siebie.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nadzieja jest rośliną trudną do wyplenienia. Można nie wiem ile odrąbać gałęzi i zniszczyć, a zawsze będzie wypuszczać nowe pędy.", Author = "Isadora Duncan", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "To nasze podejście do życia determinuje podejście życia w stosunku do nas.", Author = "Earl Nightingale", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ten, kto posiądzie umiejętność władania własnym umysłem, może objąć w posiadanie wszystko inne, do czego ma słuszne prawo.", Author = "Andrew Carnegie", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Żadne drzewo nie jest mocne ani odporne na burze, jeżeli często nie wstrząsają nim wichury, i właśnie pod nękającym naporem burzy nabiera siły i jeszcze mocniej korzeniami utwierdza się w ziemi. Słabe są drzewa, które wzrosły na słonecznych dolinach.", Author = "Seneka", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Większość ludzi goni za przyjemnością w takim pośpiechu, że przebiega obok niej.", Author = "Soren Kierkegaard ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek docenia uroki codziennego życia, kiedy budzi się z koszmarnego snu, albo kiedy po raz pierwszy wstaje z łóżka po chorobie. Dlaczego nie uświadomić sobie tego teraz?", Author = "William Lyon Phelps", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Umieć żyć to najrzadziej spotykana rzecz na świecie. Większość ludzi tylko egzystuje.", Author = "Oscar Wilde", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kiedy trzeba wspiąć się na górę, nie myśl, że jak będziesz stał i czekał, góra zrobi się mniejsza.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Każdy dzień jest małym życiem.", Author = "Arthur Schopenhauer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Myślenie, że możesz zarabiać tylko kiedy pracujesz jest jak myślenie, że możesz słuchać muzyki, tylko wtedy, gdy ktoś ją wykonuje na żywo.", Author = "Steve Pavlina", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Życie jest proste. Wszystko się wydarza dla Ciebie, nie Tobie. Wszystko dzieje się w idealnie dobrym momencie, ani zbyt wcześniej ani zbyt późno. Nie musi Ci się to podobać..tyle, że jest łatwiej, jeśli będzie.", Author = "Byron Katie", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Największym błędem jaki możesz zrobić w życiu jest ciągłe obawianie się, że popełnisz błąd.", Author = "Elbert (Green) Hubbard", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Sztuka życia polega mniej na eliminowaniu naszych problemów, a bardziej na rozwijaniu się dzięki nim.", Author = "Bernard Baruch", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Koń wyścigowy, który stale biega tylko o sekundę szybciej niż inny koń, jest wart o miliony dolarów więcej. Bądź gotów dać z siebie ten dodatkowy wysiłek, który odróżnia zwycięzcę od zdobywcy drugiego miejsca.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Szczęście jest funkcją akceptacji tego, co jest.", Author = "Werner Erhard", IsFavorite = false });
            //db.Citations.InsertOnSubmit(new Citation() { Content = "", Author = "", IsFavorite = false });

            // Zapisz zmiany w bazie
            db.SubmitChanges();

        }

        #endregion


        #region AKTUALIZACJA 1.1.2.2

        public static void AddUpdate_1122(CitationDataContext db)
        {
            // Dodaj cytaty
            db.Citations.InsertOnSubmit(new Citation() { Content = "Niektórzy mają tysiące powodów dla których nie mogą zrobić tego, co chcą zrobić, podczas gdy wszystkim, czego potrzebują, jest jeden powód, dla którego jednak mogą.", Author = "Willis Whitney", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Żyjesz tylko raz, ale jeżeli żyjesz dobrze, to wystarczy.", Author = "Joe E.Lewis", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Powodzenie nie trwa wiecznie, a porażka nie jest katastrofą.", Author = "Winston Churchill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli wydaje Ci się, że jesteś od kogoś gorszy lub bardzo obawiasz się błędu, to znacząco rośnie ryzyko, że go popełnisz. Jeśli jednak jesteś skoncentrowany, wiesz, co chcesz zrobić i nie panikujesz - to jest dobrze.", Author = "Robert Kubica", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Doświadczenie to słowo, którym ludzie określają swoje błedy.", Author = "Oscar Wilde", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Na szczęście gdzieś pomiędzy przypadkiem a tajemnicą znajduje się wyobraźnia, jedyna rzecz, która chroni naszą wolność, mimo tego, że ludzie starają się ją ograniczać albo całkiem zniszczyć.", Author = "Luis Bunuel", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie liczy się to, czy przewidziałeś deszcz. Liczy się, czy zbudowałeś arkę. Noe nie czekał z budową arki, aż spadnie deszcz.", Author = "Warren Buffet ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Życie jest zbyt ważne, aby je brać na poważnie.", Author = "Oscar Wilde ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pamiętaj, to nie od ilości zarobionych pieniędzy zależy jakość twojego myślenia i życia, ale od jakości twojego myślenia zależy ilość pieniędzy, które zatrzymasz, i jakość twojego życia.", Author = "Robert Krool", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pod żadnym względem nie jesteś gorszy od innych. Szanuj siebie, szanuj swój wewnętrzny głos i podążaj za nim.", Author = "Osho", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jedynym źródłem wiedzy jest doświadczenie.", Author = "Albert Einstein", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Problem dobrze zdefiniowany jest w połowie rozwiązany.", Author = "Charles Kettering", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pesymista widzi trudności w każdej możliwości, optymista widzi możliwości w każdej trudności.", Author = "Winston Churchill ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bo jeżeli nic nie tworzę, jeżeli nie działam na taką skalę i nie wyryję żadnego śladu na powierzchni ziemi, po której chodzę, to po co żyję?", Author = "Jan Szczepański", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wszystko, co potrafimy sobie wyobrazić, jest realne.", Author = "Pablo Picasso", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie ma nic prostrzego niż samooszukiwanie się. Człowiek wierzy w to, w co pragnie wierzyć.", Author = "Demostenes", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie takie ważne, żeby człowiek dużo wiedział, ale żeby dobrze wiedział, nie żeby umiał na pamięć, a żeby rozumiał, nie żeby go wszystko troszkę obchodziło, a żeby go coś naprawdę zajmowało.", Author = "Janusz Korczak", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Istotnych problemów, przed którymi stoimy, nie możemy rozwiązać, dysponując taką samą wiedzą, jaką mieliśmy wtedy, gdy je stwarzaliśmy.", Author = "Albert Einstein", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nic, co nowe, nie jest doskonałe.", Author = "Cyceron", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Większą radość daje zdobycie szczytu górskiego po kilkugodzinnej intensywnej wspinaczce, niż po kilkuminutowej jeździe kolejką linową.", Author = "Antoni Kępiński", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Spędziłem większość życia, martwiąc się o rzeczy, które nigdy się nie wydarzyły.", Author = "Mark Twain", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bóg daje nam łaskę pogodzenia się z tym, czego nie można zmienić. Odwagę, by zmieniać to, co można zmienić. I mądrość, byśmy odróżnili jedno od drugiego.", Author = "Reinhold Niebuhr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli widziałem dalej niż inni - działo się tak dlatego, że stałem na ramionach gigantów.", Author = "Isaac Newton", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nieuprzejmość, to imitacja siły słabego człowieka.", Author = "Eric Hoffer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przyjaźń często kończy się miłością, ale miłość przyjaźnią nigdy.", Author = "Charles C. Colton", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Stwórz konkretny plan spełnienia Twojego pragnienia i bez względu na to, czy jesteś gotowy czy nie, zacznij natychmiast wprowadzać go w życie.", Author = "Napoleon Hill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Za każdym sukcesem stoi płonąca, wręcz nieugaszona motywacja.", Author = "Nikodem Marszałek ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli spodziewasz się zbyt wiele, to nic nie jest w stanie Cię zadowolić. Kiedy niczego nie oczekujesz - wszystko może Cię uszczęśliwić.", Author = "Samuel Hazo", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bądź ostrożny w wyborze swojego środowiska, bo ono Cię ukształtuje. Bądź ostrożny w wyborze swoich przyjaciół, bo staniesz się taki, jak oni.", Author = "W. Clement Stone", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czas jest wartościowszy od pieniędzy. Możesz dostać więcej pieniędzy, ale nie możesz dostać więcej czasu.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Małe czyny, które robisz są lepsze niż wielkie, które planujesz.", Author = "George Catlett Marshall ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Większość rzeczy na tym świecie stworzona została przez ludzi, którzy wytrwali, kiedy zdawało się, że nie ma już nadziei.", Author = "Dale Carnegie", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Życie spędzone na popełnianiu błędów jest nie tylko zacniejsze, ale także bardziej użyteczne niż życie spędzone na nie robieniu niczego.", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nikt nie zrobił większego błędu niż ten, kto nic nie zrobił, bo mógł zrobić tylko trochę.", Author = "Edmund Burke", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wszystko można osiągnąć, gdy człowiek się uprze i wytrwale dąży do celu. Takie cuda zdarzają się codziennie.", Author = "Anthony Robbins", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek nie jest stary, dopóki żalem nie zastąpi marzeń.", Author = "John Barrymore", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Motywacja jest motorem Twoich poczynań, ale do celu prowadzą Cię przyzwyczajenia.", Author = "William James", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeżeli możesz dać swoim dzieciom tylko jeden podarek, niech to będzie entuzjazm.", Author = "Bruce Barton", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek musi przebywać z samym sobą, powinien więc zadbać, aby było to dobre towarzystwo.", Author = "Charles Hughes", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek potrafiący marzyć jest o wiele potężniejszy od człowieka, który ma ogromną wiedzę w danym temacie, jest świetnym specjalistą – ponieważ wiedza, nawet najgłębsza na dany temat, jest ograniczona i przewidywalna, a marzenia są nieograniczone.", Author = "Robert Kiyosaki", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Są ludzie, którzy zawsze wynajdą powody, żebyś nie robił tego, co chcesz robić. Nie zwracaj na nich uwagi.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Żyje naprawdę, kto jest użyteczny dla wielu, żyje naprawdę, kto rozporządza sobą; ci natomiast, którzy siedzą w ukryciu i gnuśnieją, tak pozostają w domu, jak w grobie. U nich na progu można wyryć w marmurze imiona; oni umarli za życia.", Author = "Seneka", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Efektywne przywództwo nie polega na przemawianiu czy też byciu lubianym. Przywództwo jest zdefiniowane przez rezultaty, nie atrybuty.", Author = "Peter Drucker", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dopóki walczysz, jesteś zwycięzcą.", Author = "św.Augustyn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Każdy powinien mieć kogoś, z kim mógłby szczerze pomówić, bo choćby człowiek był niewiadomo jak dzielny, czasami czuje się bardzo samotny.", Author = "Ernest Hemingway", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie oczekujcie od dnia tego, co mogą dać jedynie lata. Ale nie zapominajcie, że lata składają się z wielu dni, dlatego postanówcie, że nie zmarnujecie ani jednego dnia.", Author = "Johan Michael Sailer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jest tylko jedna klasa społeczna, która myśli o pieniądzach częściej niż bogaci. Stanowią ją biedni.", Author = "Oscar Wilde", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Istnieją dwa rodzaje nieudaczników: ci, którzy pomyśleli, ale nigdy nie zrobili, oraz ci, którzy zrobili, ale nigdy nie pomyśleli.", Author = "Laurence Peter", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Tego więc musimy się najbardziej wystrzegać, byśmy zwyczajem owiec nie postępowali za trzodą ciągnącą na przodzie, idąc nie tam, dokąd iść trzeba, ale tam, dokąd się zwykło.", Author = "Seneka", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zapytaj siebie, co robiłbyś nawet, gdyby nikt Ci za to nigdy nie miał zapłacić. To wskazówka, która pokaże Ci, czym powinieneś się zajmować, oczywiście wciąż szukając sposobu na zarobienie na tym.", Author = "Joe Vitale", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeżeli jakaś rzecz jest dla ciebie trudna, nie należy przypuszczać, że jest niemożliwa do spełnienia dla człowieka. Ale jeżeli jakaś rzecz jest możliwa i dostępna dla człowieka, uważaj, że jest także do osiągnięcia dla ciebie.", Author = "Marek Aureliusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jedynym sposobem, by uniknąć zepsucia pod wpływem pochwał, jest pracować dalej. Innego wyjścia nie ma.", Author = "Albert Einstein", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Musimy stać się dobrzy w jednej z dwóch rzeczy - sadzeniu wiosną lub żebraniu jesienią.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nigdy nie patrz z góry na nikogo, chyba że właśnie pomagasz mu wstać.", Author = "Jesse Jackson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wszyscy powinniśmy troszczyć się o przyszłość, bo w niej spędzimy resztę życia.", Author = "Charles Kettering", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dobrze zrobione jest lepsze niż dobrze powiedziane.", Author = "Benjamin Franklin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Analfabetami XXI wieku będą ci, którzy nie umieją się uczyć, oraz ci, którzy nie są w stanie oduczyć się tego, czego już się nauczyli i uczyć się na nowo.", Author = "Alvin Toffler", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie wierz, że zrobisz wielki postęp robiąc to, co niekonieczne, trzy razy szybciej.", Author = "Peter Drucker", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dwa rodzaje ludzi niczego nie osiągną: ci, którzy wstają dopiero długo po obudzeniu się, oraz ci, którzy się budzą dopiero długo po wstaniu.", Author = "Eleanor Roosevelt", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pamiętaj, że to, co słuszne, nie zawsze jest popularne, a to, co popularne, nie zawsze jest słuszne.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie odkrywa się nowych lądów bez pogodzenia się ze straceniem z oczu wybrzeża na bardzo długi czas.", Author = "Andre Gide", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Twoim zadaniem jest odkryć swe dzieło i oddać się mu całym sercem.", Author = "Budda", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dla człowieka, który dysponuje tylko młotkiem, wszystko, co spotyka zaczyna wyglądać jak gwóźdź.", Author = "Abraham Maslow", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli ograniczymy swoją wolność, by uzyskać bezpieczeństwo - stracimy obie te rzeczy.", Author = "Benjamin Franklin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Za nieśmiertelnością tęsknią miliony, które nie wiedzą co zrobić ze sobą w deszczowe niedzielne popołudnie.", Author = "Susan Ertz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nigdy nie podziwiaj ludzi za bogactwo, ale za twórcze i szczodre sposoby jego wykorzystania.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Szczęście występuje gdy to, co myślisz, to co mówisz i to co robisz jest w harmonii.", Author = "Mahatma Gandhi", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Porażka inspiruje zwycięzców. To jest ich największy sekret.", Author = "Robert Kiyosaki", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli chcesz mieć wrogów, bądź lepszy od swoich przyjaciół. Lecz jeśli chcesz mieć przyjaciół, pozwól, aby przyjaciele byli lepsi od ciebie.", Author = "François de La Rochefoucauld", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Przyszłość należy do tych, którzy wierzą w piękno swoich marzeń.", Author = "Eleanor Roosevelt", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pomyśl, zanim wydasz pieniądze. Czy dzięki tym wydatkom przybliżysz się do swoich celów, czy wyrzucasz przez okno kolejną możliwość inwestycji.", Author = "Robert Krool", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Największym dobrem jakie możesz wyświadczyć drugiemu jest nie tylko podzielenie się z nim swoim bogactwem, ale odkrycie przed nim jego własnego bogactwa.", Author = "Benjamin Disraeli", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Żeby w życiu coś osiągnąć, trzeba być wcześniej przygotowanym do wykorzystania szansy, która może nadejść.", Author = "Leszek Balcerowicz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dziecko może nauczyć dorosłego trzech rzeczy: cieszyć się bez powodu, być ciągle czymś zajętym i domagać się - ze wszystkich sił - tego, czego się pragnie.", Author = "Paulo Coelho", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ciężki trening, łatwa walka; łatwy trening, ciężka walka.", Author = "Aleksandr Wasiljewicz Suworow", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli celujesz w nic - trafisz za każdym razem.", Author = "Zig Ziglar", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nic nie zrobiłem dobrego dziś nikomu - dzień to stracony bezużytecznie.", Author = "Marek Aureliusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Tylko najmądrzejsi i najgłupsi ludzie nigdy się nie zmieniają.", Author = "Konfucjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czynność jest matką pomyślności. Bóg niczego pracującym nie odmawia. Pracuj przez ten czas, kiedy leniwy zasypia, a będziesz miał zboże do sprzedaży i do schowania.", Author = "Benjamin Franklin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli człowiek nie umie w miarę zarabiania oszczędzać, pracując przez całe życie przykuty do swego zatrudnienia umrze jednakże bez grosza.", Author = "Frank A. Clark", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek sukcesu to ktoś, kto potrafi zbudować solidne fundamenty z cegieł, którymi inni w niego rzucają.", Author = "David Brinkley", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Zadowolenie czyni biednego bogatym, niezadowolenie czyni bogatego biednym.", Author = "Benjamin Franklin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli od czasu do czasu nie ponosisz porażki - oznacza to, że nie robisz nic bardzo innowacyjnego.", Author = "Woody Allen", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pasja jest absolutnie konieczna do osiągnięcia długotrwałego sukcesu jakiegokolwiek rodzaju.", Author = "Donald Trump", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Tylko ci, którzy ryzykują pójście za daleko, dowiedzą się, jak daleko mogą zajść.", Author = "Thomas Stearns Eliot", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Praca rozumna i wytrwała, która nie myśli o zbieraniu owoców w tydzień po posiewie, przebija góry, nad przepaściami przerzuca mosty.", Author = "Bolesław Prus", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nic tak człowieka nie męczy, jak nie dokończona robota, która nad nami wisi.", Author = "William James", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dziel z innymi swój chleb, a lepiej będzie ci smakował.", Author = "Phil Bosmans", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie nauczysz się pływać nie wchodząc do wody.", Author = "Bruce Lee", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Pamiętaj, że wielka miłość i wielki sukces wymagają podjęcia wielkiego ryzyka.", Author = "H. Jackson Brown, Jr", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nigdy się nie wzbogacisz będąc chorągiewką na wietrze.", Author = "Warren Buffet", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nigdy nie rezygnuj z celu tylko dlatego, że osiągnięcie go wymaga czasu. Czas i tak upłynie.", Author = "H. Jackson Brown Jr.", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nieważne skąd pochodzisz. Ważne dokąd zmierzasz.", Author = "Brian Tracy", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dbaj o swoje ciało. To jedyne miejsce, w którym żyjesz.", Author = "Jim Rohn", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Konwencjonalny pogląd jest po to, by ochronić nas od bolesnej pracy zwanej myśleniem.", Author = "John Kenneth Galbraith", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ludzki umysł potrafi osiągnąć wszystko, w co potrafi uwierzyć.", Author = "Napoleon Hill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Cierpliwość i wytrwałość mają magiczne działanie - dzięki nim trudności znikają, a przeszkody ulatniają się.", Author = "John Quincy Adams", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie bój się dużego kroku. Nie pokonasz przepaści dwoma małymi.", Author = "David Lloyd George", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie musisz być wielki, aby zacząć, ale musisz zacząć, aby być wielkim.", Author = "Les Brown", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Tak młody jak dziś nie będziesz już nigdy. Wykorzystaj to z myślą o Twoim jutrze.", Author = "Norman Cousins", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Prawdziwa decyzja jest mierzona poprzez fakt podjęcia nowego działania. Jeśli nie ma działania - tak naprawdę nie podjąłeś decyzji.", Author = "Anthony Robbins", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Należy tak organizować życie, aby każda chwila była ważna.", Author = "Iwan Turgieniew", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czy rzeczywiście potrzebujemy więcej czasu? Czy też potrzebujemy więcej dyscypliny, by wykorzystać czas, który mamy?", Author = "Kerry Johnson", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto żyje bez szaleństwa, mniej jest rozsądny niż mniema.", Author = "François de La Rochefoucauld", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Inspiracja istnieje, ale musi zastać Cię przy pracy.", Author = "Pablo Picasso", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli przy drodze do sukcesu tylko siedzisz, to mogą cię wyłącznie rozjechać.", Author = "Joseph O'Connor", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wysokie oczekiwania są kluczem do wszystkiego.", Author = "Sam Walton", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Aby samemu stać się lepszym, nie musisz czekać na lepszy świat.", Author = "Phil Bosmans", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kim się stajemy zależy od tego, co czytamy kiedy zakończymy już standardową edukację. Najlepszym uniwersytetem ze wszystkich jest kolekcja książek.", Author = "Thomas Carlyle", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "W czasie uczty nie opowiadaj jak należy jeść, ale jedz jak należy.", Author = "Epiktet z Hierapolis", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wysokie wynagrodzenie i niewielka odpowiedzialność rzadko idą ze sobą w parze.", Author = "Napoleon Hill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Stoicka zasada zaspokajania potrzeb poprzez rezygnację z pragnień jest jak amputacja stóp po to, by nie potrzebować butów.", Author = "Jonathan Swift ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najpierw marnujemy zdrowie, aby dojść do pieniędzy, potem marnujemy pieniądze, aby dojść do zdrowia.", Author = "Robert Lembke", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dzieci przywiązują małą wagę do nauczania, które dostają od swoich rodziców, za to wiernie odwzorowują ich charaktery.", Author = "Mason Cooley", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Możemy zrealizować każde zamierzenie, jeśli potrafimy trwać w nim wystarczająco długo.", Author = "Helen Keller", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czasem radość jest źródłem Twojego uśmiechu, ale czasem Twój uśmiech może stać się źródłem radości.", Author = "Thich Nhat Hanh", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie możesz zbudować swojej reputacji na tym, co dopiero zamierzasz zrobić.", Author = "Henry Ford", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Karty z przeszłości każdy tasuje, jak mu pasuje.", Author = "Stephen King", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Serce nigdy się nie starzeje, ma tylko coraz więcej blizn.", Author = "Johann Wolfgang Goethe ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Motywacja jest tym, co pozwala Ci zacząć. Nawyk jest tym, co pozwala Ci wytrwać.", Author = "Jim Ryun", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli chce się być szczęśliwym, nie wolno gmerać w pamięci.", Author = "Emil Cioran", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Najpiękniejszych chwil w życiu nie zaplanujesz. One przyjdą same.", Author = "Phil Bosmans", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ludzie nie są więźniami losu, a jedynie więźniami swoich własnych umysłów.", Author = "Franklin Delano Roosevelt", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Stan Twojego życia jest niczym innym, jak odbiciem stanu Twojego umysłu.", Author = "Wayne Dyer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "To, że zarabiamy pozwala nam przetrwać. Naprawdę żyjemy dopiero wówczas, gdy dzielimy się z innymi.", Author = "Winston Churchill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Największym człowiekiem jest ten, który jest panem samego siebie.", Author = "Seneka", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie obawiaj się porzucić czegoś dobrego dla czegoś wspaniałego.", Author = "John D. Rockefeller", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kropla drąży skałę nie siłą, lecz często padając.", Author = "Owidiusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bądź wdzięczny za to, co masz, a będziesz miał tego więcej. Jeśli koncentrujesz się na tym, czego nie masz, nigdy nie będziesz miał wystarczająco dużo.", Author = "Oprah Winfrey", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "To, jakim jestem człowiekiem, jest nieskończenie ważniejsze od tego, co posiadam.", Author = "Phil Bosmans", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dla umysłu nie istnieją ograniczenia, poza tymi, które samodzielnie uznamy za prawdziwe.", Author = "Napoleon Hill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wyobraźnia jest ważniejsza od wiedzy.", Author = "Albert Einstein ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Głównym powodem porażki i nieszczęścia jest wymienianie tego, czego najbardziej pragniesz na to, czego pragniesz teraz.", Author = "Zig Ziglar", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Nie możemy nic zmienić, jeśli tego najpierw nie zaakceptujemy.", Author = "Carl Gustav Jung ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Niezdecydowanie jest największą chorobą.", Author = "Johann Wolfgang von Goethe", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Bądź światłem sam dla siebie.", Author = "Budda", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kluczem do szczęścia jest posiadanie marzeń, kluczem do sukcesu jest ich realizacja.", Author = "James Allen ", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "To nie najmocniejsze gatunki przetrwają, ani nie te najbardziej inteligentne, ale te, które najlepiej przystosowują się do zmian.", Author = "Karol Darwin", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto potrafi cieszyć się z małych rzeczy, mieszka w ogrodzie pełnym szczęśliwości.", Author = "Phil Bosmans", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wyzwaniem jest nie zarządzanie czasem, a zarządzanie samym sobą.", Author = "Stephen Covey", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Na końcu swojego życia pomyślisz sobie, w jaki sposób mogłeś przeżyć każdy miniony dzień. Wtedy jednak nie będziesz mógł cofnąć czasu. Zacznij więc tak żyć już teraz!", Author = "Marek Aureliusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Umysły są jak spadochrony - działają tylko gdy są otwarte.", Author = "Thomas Dewar", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jeśli pragniesz latać wśród orłów, nie możesz bez przerwy zadawać się z indykami.", Author = "Zig Ziglar", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Znajdź sobie dobre towarzystwo. Współpracuj z pozytywnymi, zorientowanymi na cele ludźmi, którzy inspirują Cię i pobudzają do działania.", Author = "Brian Tracy", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kochać siebie samego to początek romansu na całe życie.", Author = "Oscar Wilde", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Czytając życiorysy wielkich ludzi odkryłem, że ich pierwszym zwycięstwem było pokonanie samego siebie.", Author = "Harry Truman", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Lepiej jest zapalić choćby mała świeczkę, niż kląć na ciemności.", Author = "Konfucjusz", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Słowo jest tylko cieniem czynu.", Author = "Demokryt", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Połowy dzieła dokonał, kto zaczął.", Author = "Horacy", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "O radę pytaj tego, kto sobie sam radzi.", Author = "Leonardo da Vinci", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto życia nie ceni, nie wart go.", Author = "Leonardo da Vinci", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wasz czas jest ograniczony, więc nie marnujcie go na życie cudzym życiem.", Author = "Steve Jobs", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ważne jest, aby pozwolić pewnym rzeczom odejść .. Uwolnić się od nich. Odciąć. Zamknąć cykl. Nie z powodu dumy, słabości czy pychy, ale po prostu dlatego, że na coś już nie ma miejsca w Twoim życiu .. Zamknij drzwi, zmień płytę, posprzątaj dom, strzepnij kurz. Przestań być tym, kim byłeś. Bądź tym, kim jesteś .. Musisz zrozumieć, że to nie jest gra znaczonymi kartami. Raz wygrywamy, raz przegrywamy. Nie oczekuj, że inni Ci coś zwrócą, docenią Twój wysiłek, odkryją Twój geniusz, odwzajemnią Twoją miłość.", Author = "Paulo Coelho", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Dlaczego nie możemy byś szczęśliwi teraz, przecież jutro możemy już nie żyć.", Author = "Tennessee Williams", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Kto nie chce kiedy może, ten nie będzie mógł kiedy będzie chciał.", Author = "Winston Churchill", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Sukces nie jest kluczem do szczęścia. Szczęście jest kluczem do sukcesu. Jeśli kochasz to, co robisz - osiągniesz sukces.", Author = "Albert Schweitzer", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Powiedz mi, kim są twoi przyjaciele, a powiem ci, kim jesteś.", Author = "Ernest Hemingway", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Wiek powoduje zmarszczki na ciele. Poddawanie się - na duszy.", Author = "Douglas MacArthur", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Ideały są jak gwiazdy. Jeśli nawet nie możemy ich osiągnąć, to należy się według nich orientować.", Author = "George Bernard Shaw", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "By być wielkim mistrzem, musisz wierzyć, że jesteś najlepszy. Jeśli to nieprawda - udawaj, że jednak jesteś.", Author = "Muhammad Ali", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Jak łatwo marzyć, kiedy się jest dzieckiem. Wtedy wszystko wydaje się możliwe. Kiedy człowiek dorasta, zaczyna sobie uświadamiać, ilu rzeczy nie wolno pragnąć, bo są niedozwolone, grzeszne, nieuczciwe.", Author = "Laura Esquivel", IsFavorite = false });
            db.Citations.InsertOnSubmit(new Citation() { Content = "Człowiek, który nie czyta dobrych książek, nie ma przewagi nad kimś, kto nie umie czytać.", Author = "Mark Twain", IsFavorite = false });

            // Zapisz zmiany w bazie
            db.SubmitChanges();

        }

        #endregion
    }
}
