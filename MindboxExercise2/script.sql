create table Category
(
    Id   int identity
        constraint Category_pk
            primary key,
    name nvarchar(50) not null
);

create unique index Category_Id_uindex
    on Category (Id)
;

create table Product
(
    Id   int identity
        constraint Product_pk
            primary key,
    name nvarchar(50) not null
);

create unique index Product_Id_uindex
    on Product (Id)
;

create table ProductCategory
(
    ProductId  int not null
        constraint ProductCategory__ProductId__fk
            references Product
            on delete cascade,
    CategoryId int not null
        constraint ProductCategory__CategoryId__fk
            references Category
            on delete cascade
);
go

select P.name, C.name
from Product P
left join ProductCategory PC on P.Id = PC.ProductId
left join Category C on PC.CategoryId = C.Id
order by P.name
;
