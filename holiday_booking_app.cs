using System; 

 

public class Program 

{ 

public static void Main() 

{ 

int DestSelect=0; 

int hotelSelect=0; 
	
int weekSelect=0;	

int adultNumber=0;

int childNumber=0;	

int destPrice=0; 

int hotelPrice=0; 
	
int hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);
	
int childPrice=((hotelPrice * weekSelect * childNumber) / 2);
	
int totalPrice=(hotelTotalAdult + childPrice + destPrice);

Console.WriteLine("Holiday System"); 

Console.WriteLine("1: Spain = 200"); 

Console.WriteLine("2: UK = 0"); 

Console.WriteLine("3: France = 120"); 

Console.WriteLine("Make selection 1, 2, or 3"); 

 

DestSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected: " + DestSelect); 

  

////////////////////////////////////////////////////////////////////////// 

if(DestSelect==1) 

{// dest 1 if started 

destPrice=200;  

Console.WriteLine("You selected Spain at " + destPrice); 

Console.WriteLine("Hotels in Spain"); 

	Console.WriteLine("Hotel 1: Hotel Uno at 100"); 

	Console.WriteLine("Hotel 2: Hotel Dos at 200"); 

	Console.WriteLine("Hotel 3: Hotel Tres at 300"); 

Console.WriteLine("Make selection 1, 2 or 3"); 

 

hotelSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected " + hotelSelect); 

 

if (hotelSelect==1) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Uno"); 

	hotelPrice=100; 

	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);


} 

  

else if (hotelSelect==2) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Dos"); 

	hotelPrice=200; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

	} 

  

else if (hotelSelect==3) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Tres"); 

	hotelPrice=300; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

} 

}// dest 1 if ended 

  

//////////////////////////////////////////////////////////////////////////////////// 

else if (DestSelect==2) 

{// dest 2 if started 

destPrice=0; 

Console.WriteLine("You selected UK at " + destPrice); 

Console.WriteLine("Hotels in UK"); 

	Console.WriteLine("Hotel 1: Hotel One at 100"); 

    Console.WriteLine("Hotel 2: Hotel Two at 200"); 

    Console.WriteLine("Hotel 3: Hotel Three at 300"); 

Console.WriteLine("Make selection 1, 2 or 3"); 

 

hotelSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected " + hotelSelect); 

 

if (hotelSelect==1) 

{ 

	Console.WriteLine("Thank you for selecting Hotel One"); 

	hotelPrice=100; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);
	} 

  

else if (hotelSelect==2) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Two"); 

	hotelPrice=200; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

	} 

  

else if (hotelSelect==3) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Three"); 

	hotelPrice=300;

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

	} 

}// dest 2 if ended 

  

//////////////////////////////////////////////////////////////////////////////

if(DestSelect==3) 

{// dest 3 if started 

destPrice=120; 

Console.WriteLine("You selected France at " + destPrice); 

Console.WriteLine("Hotels in France"); 

	Console.WriteLine("Hotel 1: Hotel Un at 100"); 

    Console.WriteLine("Hotel 2: Hotel Deux at 200"); 

    Console.WriteLine("Hotel 3: Hotel Trois at 300"); 

Console.WriteLine("Make selection 1, 2 or 3"); 

 

hotelSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected " + hotelSelect); 

 

if (hotelSelect==1) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Un"); 

	hotelPrice=100; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

} 

  

else if (hotelSelect==2) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Deux"); 

	hotelPrice=200; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

} 

  

else if (hotelSelect==3) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Trois"); 

	hotelPrice=300; 

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("The total cost is £" + totalPrice);

} 

}// dest 3 if ended 

} 

} 