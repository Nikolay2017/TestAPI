select p.product_name,catalog_name=isnull(c.catalog_name,'') from product p
LEFT JOIN product_catalod pc on pc.product_id=p.id
LEFT join catalog c on c.id=pc.catalog_id