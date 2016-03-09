/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package inval;

/**
 *
 * @author LouiseBraddick
 */
import java.util.ArrayList; 
import java.util.Arrays;
import java.util.Scanner;


public class productTester {
	private String userAns;
	
	private String proNam;
	static Scanner sc = new Scanner(System.in);
	static ArrayList<product> productList = new ArrayList<product>();
	


    public static void main(String[] args) {
        
        System.out.println ("Please enter the amount of products you wish to add");
        int addThisMany= sc.nextInt();
        if (addThisMany <= 0) {
            System.out.println("You have chosen to enter <=0");
        }
        else {
            
            
            for(int i = 0; i<addThisMany;i++){
                System.out.println("Items added so far: " +i);
                System.out.println("Please enter Item Number: ");
                int itNo = sc.nextInt();
                System.out.println("Please enter the Product Name: ");
                String proNam = sc.next();
                System.out.println("Please enter Quantity of Product in Store: ");
                int qop = sc.nextInt();
                System.out.println("Please enter Product Price: ");
                double prpr = sc.nextDouble();
                
                productList.add(new product(itNo, proNam, qop, prpr));
            }
        }
        
        
        for (int i = 0; i<productList.size(); i++){
            System.out.println("");
            System.out.println("Product:");
            System.out.println(productList.get(i));
            System.out.println("Would you like to add/subtract from the above product or continue?");
            String userAns = sc.next();
            if (userAns.toLowerCase().equals("add")){
                System.out.println("Please enter the amount of units you wish to add");
                int addthis = sc.nextInt();
                productList.get(i).add(addthis);
                System.out.println("Modified Product:");
                System.out.println(productList.get(i));
            }
            
            else if (userAns.toLowerCase().equals("subtract")){
                System.out.println("Please enter the amount of units you wish to subtract");
                int subtractthis = sc.nextInt();
                productList.get(i).subtract(subtractthis);
                System.out.println("Modified Product:");
                System.out.println(productList.get(i));
            }
            else if (userAns.toLowerCase().equals("continue")){
                continue;
            }
            else{
                System.out.println("Error: Please start again");
                System.exit(0);
            }
            
        }
        System.out.println("");
        System.out.println("You have reached the end of the product list");
    }
}
       

    
       
       
  
 
	  
    

 
   
       