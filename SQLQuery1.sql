create database BanHang2
use BanHang2
go

/*----------------------------------------------------Bang San pham*/
CREATE TABLE Products (
  product_id INT PRIMARY KEY,
  product_name NVARCHAR(255),
  description TEXT,
  price DECIMAL(10, 2),
  category NVARCHAR(50)
);

INSERT INTO Products (product_id, product_name, description, price, category)
VALUES (1, 'Ao thun', 'Ao thun nam mau trang', 29.99, 'Ao');

INSERT INTO Products (product_id, product_name, description, price, category)
VALUES (2, 'Quan jeans', 'Qaần jeans nam mau xanh', 49.99, 'Quan');

INSERT INTO Products (product_id, product_name, description, price, category)
VALUES (3, 'Ao so mi', 'Ao so mi nam mau xanh duong', 39.99, 'Ao');

/*-----------------------------------------------------Bang khach hang*/
CREATE TABLE Customers (
  customer_id INT PRIMARY KEY,
  customer_name NVARCHAR(255),
  email VARCHAR(255),
  address NVARCHAR(255),
  phone VARCHAR(20)
);

INSERT INTO Customers (customer_id, customer_name, email, address, phone)
VALUES (1, 'Nguyen Van A', 'example@email.com', '123 Đuong ABC, TP. HCM', '0123456789');

INSERT INTO Customers (customer_id, customer_name, email, address, phone)
VALUES (2, 'Nguyen Thi B', 'example2@email.com', '456 Đuong XYZ, TP. HCM', '9876543210');


/*------------------------------------------------------bang don hang*/
CREATE TABLE Orders (
  order_id INT PRIMARY KEY,
  customer_id INT,
  order_date DATE,
  total_amount DECIMAL(10, 2),
  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

INSERT INTO Orders (order_id, customer_id, order_date, total_amount)
VALUES (1, 1, '2023-09-27', 99.99);

INSERT INTO Orders (order_id, customer_id, order_date, total_amount)
VALUES (2, 2, '2023-09-28', 149.99);

/*--------------------------------------------------------bang sp trong don hang*/
CREATE TABLE OrderItems (
  order_item_id INT PRIMARY KEY,
  order_id INT,
  product_id INT,
  quantity INT,
  price DECIMAL(10, 2),
  FOREIGN KEY (order_id) REFERENCES Orders(order_id),
  FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

INSERT INTO OrderItems (order_item_id, order_id, product_id, quantity, price)
VALUES (1, 1, 1, 2, 59.98);

INSERT INTO OrderItems (order_item_id, order_id, product_id, quantity, price)
VALUES (2, 2, 2, 1, 49.99);


/*------------------------------------------------------bang nguoi dung*/
CREATE TABLE Users (
  user_id INT PRIMARY KEY,
  username VARCHAR(255),
  password VARCHAR(255),
  email VARCHAR(255),
  full_name NVARCHAR(255),
  address NVARCHAR(255),
  phone VARCHAR(20)
);



INSERT INTO Users (user_id, username, password, email, full_name, address, phone)
VALUES (1, 'nguyenvana', 'password123', 'nguyenvana@example.com', 'Nguyen Van A', '123 Duong ABC, TP. HN', '0123456789');

INSERT INTO Users (user_id, username, password, email, full_name, address, phone)
VALUES (2, 'nguyenthixuan', 'password456', 'nguyenthixuan@example.com', 'Nguyen Thi Xuan', '456 Duong XYZ, TP. HN', '9876543210');


/*-------------------------------------------------------------bang Admin*/
CREATE TABLE Admin (
  admin_id INT PRIMARY KEY,
  user_id INT,
  username VARCHAR(255),
  password VARCHAR(255),
  email VARCHAR(255),
  full_name VARCHAR(255),
  role VARCHAR(50),
  FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

INSERT INTO Admin (admin_id, username, password, email, full_name, role)
VALUES
(1, 'admin1', 'password1', 'admin1@example.com', 'Admin 1', 'admin'),
(2, 'admin2', 'password2', 'admin2@example.com', 'Admin 2', 'admin'),
(3, 'admin3', 'password3', 'admin3@example.com', 'Admin 3', 'admin');

select*from admin


/*-----------------------------------------------------------------------API Products*/
create proc sp_get_all_product
as
begin
	select*from Products
end

create proc sp_create_product(@product_id int,@product_name nvarchar(255), @description text, @price decimal(10,2), @category nvarchar(50))
as
begin
	insert into Products(product_id,product_name,description,price,category)
	values (@product_id,@product_name,@description,@price,@category)
end

create proc sp_update_product(@product_id int,@product_name nvarchar(255), @description text, @price decimal(10,2), @category nvarchar(50))
as
begin
	update Products
	set product_id = @product_id, product_name = @product_name, description = @description, price = @price, category = @category
	where product_id = @product_id
end

create proc sp_delete_product(@product_id int)
as
begin
	delete from Products
	where product_id = @product_id
end


/*-----------------------------------API Customers-------------------------------------------*/
create proc sp_get_all_customer
as
begin
	select*from Customers
end

create proc sp_create_customer(@customer_id int,@customer_name nvarchar(255), @email varchar, @address nvarchar(255), @phone varchar(20))
as
begin
	insert into Customers(customer_id,customer_name,email,address,phone)
	values (@customer_id,@customer_name,@email,@address,@phone)
end


create proc sp_update_customer(@customer_id int,@customer_name nvarchar(255), @email varchar, @address nvarchar(255), @phone varchar(20))
as
begin
	update Customers
	set customer_id = @customer_id, customer_name = @customer_name, email = @email, address = @address, phone = @phone
	where customer_id = @customer_id
end

create proc sp_delete_customer(@customer_id int)
as
begin
	delete from Customers
	where customer_id = @customer_id
end
SELECT*FROM Customers



/*------------------------API Orders------------------------------------------------*/
create proc sp_get_all_order
as
begin
	select*from Orders
end

create proc sp_create_order(@order_id int,@customer_id int, @order_date date, @total_amount decimal(10,2))
as
begin
	insert into Orders(order_id,customer_id,order_date,total_amount)
	values (@order_id,@customer_id,@order_date,@total_amount)
end

create proc sp_update_order(@order_id int,@customer_id int, @order_date date, @total_amount decimal(10,2))
as
begin
	update Orders
	set order_id = @order_id, customer_id = @customer_id, order_date = @order_date, total_amount = @total_amount
	where order_id = @order_id
end

create proc sp_delete_order(@order_id int)
as
begin
	delete from Orders
	where order_id = @order_id
end


/*------------------------API OrderItems------------------------------------------------*/
create proc sp_get_all_order_item
as
begin
	select*from OrderItems
end

create proc sp_create_order_item(@order_item_id int,@order_id int, @product_id int, @quantity int, @price decimal(10,2))
as
begin
	insert into OrderItems(order_item_id, order_id, product_id, quantity, price)
	values (@order_item_id,@order_id,@product_id,@quantity,@price)
end

create proc sp_update_order_item(@order_item_id int,@order_id int, @product_id int, @quantity int, @price decimal(10,2))
as
begin
	update OrderItems
	set order_item_id = @order_item_id, order_id = @order_id, product_id = @product_id, quantity = @quantity, price = @price
	where order_item_id = @order_item_id
end

create proc sp_delete_order_item(@order_item_id int)
as
begin
	delete from OrderItems
	where order_item_id = @order_item_id
end

/*------------------------API User------------------------------------------------*/
create proc sp_get_all_user
as
begin
	select*from Users
end

create proc sp_create_user(@user_id int,@username varchar(255), @password varchar(255), @email varchar(255), @full_name nvarchar(255), @address nvarchar(255), @phone varchar(20))
as
begin
	insert into Users(user_id, username, password, email, full_name, address, phone)
	values (@user_id,@username,@password,@email,@full_name,@address,@phone)
end

create proc sp_update_user(@user_id int,@username varchar(255), @password varchar(255), @email varchar(255), @full_name nvarchar(255), @address nvarchar(255), @phone varchar(20))
as
begin
	update Users
	set user_id = @user_id, username = @username, password = @password, email = @email, full_name = @full_name,  address = @address, phone =  @phone
	where user_id = @user_id
end

create proc sp_delete_user(@user_id int)
as
begin
	delete from Users
	where user_id = @user_id
end


/*------------------------API Admin------------------------------------------------*/
create proc sp_get_all_admin
as
begin
	select*from Admin
end

create proc sp_create_admin(@admin_id int,@user_id int, @username varchar(255), @password varchar(255), @email varchar(255), @full_name varchar(255), @role varchar(50))
as
begin
	insert into Admin(admin_id, user_id, username, password, email, full_name, role)
	values (@admin_id,@user_id,@username,@password,@email,@full_name,@role)
end

create proc sp_update_admin(@admin_id int,@user_id int, @username varchar(255), @password varchar(255), @email varchar(255), @full_name varchar(255), @role varchar(50))
as
begin
	update Admin
	set admin_id = @admin_id, user_id = @user_id, username = @username,password = @password, email = @email, full_name = @full_name,  role = @role
	where user_id = @user_id
end

create proc sp_delete_admin(@admin_id int)
as
begin
	delete from Admin
	where admin_id = @admin_id
end
