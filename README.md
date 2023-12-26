Các bước cập nhật database:

Bước 1: Tạo database đặt tên là VolunteersDB trong SQL Server Management Studio.
Bước 2: Mở file data.txt, copy và execute trong SQL Server Management Studio.
Bước 3: Chạy file VolunProject.sln.
Bước 4: View -> Soluntion Explorer, tìm App.config  trong thư mục.
Bước 5:  Xóa thẻ <connectionStrings>.
Bước 6: Xóa database cũ: thư mục DATA -> EnityADO.NET -> xóa Model1.edmx.
Bước 7: Thêm database mới: EnityADO.NET -> add -> new item -> ADO.NET Enity Data Model -> EF Designer -> New Connection -> copy và paste tên của SQL Server ở phần properties vào mục Server name -> encrypt chọn thành false -> select database name chọn VolunteersDB -> OK.
Bước 8: Ở mục Save connection string, sửa tên thành VolunteerDBEntities1 -> Next -> Tích chọn ô Table -> Ok.
