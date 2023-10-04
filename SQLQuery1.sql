create database BanHang2
use BanHang2
go

/*San pham*/
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

/*khach hang*/
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

/*don hang*/
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

/*sp trong don hang*/
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

/*nguoi dung*/
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

/**/

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
drop proc sp_create_product
exec sp_create_product '4', 'ao thun','ao thun nu', '30.01', 'ao'
select*from Products

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