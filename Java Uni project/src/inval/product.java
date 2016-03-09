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
public class product {
     // Setting up variables
	private int itemNo;
	private String name;
	private int quantity;
	private double cost;
	private double invvalpro;
	// Product constructor without parametres
	public product (){
		itemNo = 0;
		name = "";
		quantity = 0;
		cost = 0.0;
		invvalpro = 0.0;
	}
	// Product with parametres
	public product(int itno, String n, int q, double p){
		itemNo = itno;
		name = n;
		quantity = q;
		cost = p;
		invvalpro = q*p;
	}
	
	// Add Method
	public void add(int addthis){
		quantity = quantity + addthis;
		invvalpro = quantity*cost;
	}
	
	// Subtract Method
	public void subtract(int subtractthis){
		quantity = quantity - subtractthis;
		invvalpro= quantity*cost;
	}
	
	// Setters methods
	public void setitemno (int itno) {
		itemNo = itno;
	}
	// Setters methods
	public void setname (String n){
		name = n;
	}
	// Setters methods
	public void setquantity (int q){
		quantity = q;
	}
	// Setters methods
	public void setcost (double p){
		cost = p;
	}
	// Setters methods
	public void setinvvalpro (double ivp){
		invvalpro = ivp;
	}
	// Getters methods
	public int getitemNo (){
		return itemNo;
	}
	// Getters methods
	public String getname (){
		return name;
	}
	// Getters methods
	public int getquantity (){
		return quantity;
	}
	// Getters methods
	public double getcost(){
		return cost;
	}
	// Getters methods
	public double getinvvalpro(){
		return invvalpro;
	}
    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        // TODO code application logic here\
        product p1 = new product ();
	        p1.setitemno  (1);
	        p1.setname ("Pen");
	        p1.setquantity (3);
	        p1.setcost (1.20);
			p1.setinvvalpro (3.60);
	        System.out.println(p1);
	    }
	// Overriding the toString() method
	@Override public String toString (){
		return String.valueOf("Item Number: " + itemNo + "  Product: " + name + " "
				+ " Quantity: " + quantity + "  Cost: " +cost +"  Inventory value for "
						+ "this product: "
				+ invvalpro);
    }
    
	
}
