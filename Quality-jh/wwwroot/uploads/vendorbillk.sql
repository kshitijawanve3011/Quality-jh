

create table VendorbillK
(
   VendorId int primary key identity,
   Department varchar(100),
   VendorName varchar(100),
   InvoiceNO varchar(100),
   WorkOrderNoPONO int,
   ContractStartDate datetime,
   ContractEndDate datetime,
   BillingPeriod varchar(100),
   Service varchar(100),
   BillingAmount int,
   BillingDay int,
   Remark varchar(100),
   ActiveInactive bit,
   UTRNO varchar(100),
   Date datetime,
   AmountPaid int 
)
select * from VendorbillK
INSERT INTO VendorbillK (Department, VendorName, InvoiceNO, WorkOrderNoPONO, ContractStartDate, ContractEndDate, BillingPeriod, Service, BillingAmount, BillingDay, Remark, ActiveInactive, UTRNO, Date, AmountPaid) 
VALUES 
('Sales', 'ABC Company', 'INV001', 1001, '2024-01-01', '2024-06-30', 'Monthly', 'Consulting', 5000, 15, 'Initial billing', 1, 'UTR123456', '2024-04-20', 4500),
('Marketing', 'XYZ Inc.', 'INV002', 1002, '2024-02-01', '2024-07-31', 'Quarterly', 'Advertising', 8000, 10, 'First quarter billing', 1, 'UTR987654', '2024-04-20', 6000),
('Finance', 'LMN Corp', 'INV003', 1003, '2024-03-01', '2024-08-31', 'Monthly', 'Accounting', 6000, 20, 'Monthly retainer', 1, 'UTR456789', '2024-04-20', 5500),
('IT', 'PQR Solutions', 'INV004', 1004, '2024-04-01', '2024-09-30', 'Yearly', 'Software Development', 10000, 5, 'Annual software license fee', 1, 'UTR345678', '2024-04-20', 9500),
('HR', 'EFG Services', 'INV005', 1005, '2024-05-01', '2024-10-31', 'Monthly', 'Recruitment', 7000, 25, 'Monthly hiring charges', 1, 'UTR234567', '2024-04-20', 6500);

