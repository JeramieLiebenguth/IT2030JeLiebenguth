package assignment1b;
import java.text.DecimalFormat;

import java.util.ArrayList;

import java.util.Scanner;

import javax.swing.JOptionPane;


public class TestItem {
    public static double averages(ArrayList<Item > array)

        {
            double sum = 0;

            for(int i=0;i<array.size();i++)

            {

                //if price is positive then only add as per test case 4

            if(array.get(i).getPrice() >=0)

            sum += array.get(i).getPrice();

            }

        //System.out.println("Sum:" +sum);

        return sum/array.size();

    }

    public static void printReverse(ArrayList<Item> array)

        {

            for(int i=array.size();i>=0;i--)

            {

            System.out.println(array.get(i));

            }

    }

    //to check duplicate in array

    public static boolean checkDuplicates(ArrayList<Item> array,String nameOfItem)

        {

            for(int i=0;i<array.size();i++)

            {

            if(nameOfItem.equalsIgnoreCase(array.get(i).getName()))

            return true;

            }

        return false;

    }

    public static void message()

    {

        JOptionPane.showMessageDialog(null, "Welcome to Tri-C", "Item-Price", JOptionPane.INFORMATION_MESSAGE);

    }

    public static void main(String[] args) {

        //Test 5

        System.out.println("Test 5");

        message();

        //Test 1

        System.out.println("Test 1");

        //create Default Item Object

        Item it = new Item();

        //get input from user

        it.input();

        //output using show method

        it.show();

        //Test 2

        System.out.println("Test 2");

        //create array of item

        ArrayList<Item> itemArray = new ArrayList<Item>();

        for(int i=0;i<3;i++)

        {

        Item it1 = new Item();

        it1.input();

        if(!checkDuplicates(itemArray, it1.getName()))

        itemArray.add(it1);

        else

        System.out.println("Duplicate Item add different");

        }

        //Test 2

        double avgPrice = averages(itemArray);

        DecimalFormat df = new DecimalFormat();

        df.setMaximumFractionDigits(2);

        //find Average

        for(int i=0;i<3;i++)

        {

        System.out.println("Item name: "+itemArray.get(i).getName() + " having average price: $"+df.format(avgPrice));

        }

    //Test 3

    System.out.println("Test 3");

        boolean found = false;

        for(int i=0;i<itemArray.size();i++)

        {

        if("Peas".equalsIgnoreCase(itemArray.get(i).getName()))

        {

        found = true;

        }

}

if(found == true)

{

    for(int i=0;i<3;i++)

    {

    System.out.println("Item name: "+itemArray.get(i).getName() + " having average price: $"+df.format(avgPrice));

    }

}

else

{

    System.out.println("“no average output.");

}

System.out.println("Test 4");

ArrayList<Item> itemArrayBig = new ArrayList<Item>();

for(int i=0;i<100;i++)

{

Item it1 = new Item();

it1.input();

if(!checkDuplicates(itemArray, it1.getName()))

itemArray.add(it1);

else

System.out.println("Duplicate Item add different");

}

avgPrice = averages(itemArrayBig);

found = false;

for(int i=0;i<itemArray.size();i++)

{

if("Peas".equalsIgnoreCase(itemArray.get(i).getName()))

{

found = true;

}

}

if(found == true)

{

for(int i=0;i<3;i++)

{

System.out.println("Item name: "+itemArray.get(i).getName() + " having average price: $"+df.format(avgPrice));

}

}

else

{

System.out.println("“no average output.");

}

    //Test 6

System.out.println("Test 6");

printReverse(itemArrayBig);

System.out.println("Test 7");

System.out.println("Do not want to continue enter no");

Scanner sc = new Scanner(System.in);

String str = sc.next();

while(!str.equalsIgnoreCase("no")) {

itemArray.clear();

for(int i=0;i<3;i++)

{

Item it1 = new Item();

it1.input();

if(!checkDuplicates(itemArray, it1.getName()))

itemArray.add(it1);

else

System.out.println("Duplicate Item add different");

}

avgPrice = averages(itemArray);

found = false;

for(int i=0;i<itemArray.size();i++)

{

if("Peas".equalsIgnoreCase(itemArray.get(i).getName()))

{

found = true;

}

}

if(found == true)

{

for(int i=0;i<3;i++)

{

System.out.println("Item name: "+itemArray.get(i).getName() + " having average price: $"+df.format(avgPrice));

}

}

else

{

System.out.println("“no average output.");

}

}

}

}


