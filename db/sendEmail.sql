/*EXEC msdb.dbo.sp_send_dbmail
@profile_name = 'NguyenLong', -- tên profile tạo ở trong SQL
@recipients = 'longdaz2003@gmail.com', -- danh sách các địa chỉ nhận
@body = '<h3 style="color: red;">Xin chào</h3>', -- nội dung email
@body_format = 'HTML', -- định dạng Email
@subject = 'Email được gửi' -- tiêu đề Email*/

EXEC msdb.dbo.sp_send_dbmail
@profile_name = 'F4', -- tên profile tạo ở trong SQL
@recipients = 'chiboha070903@gmail.com', -- danh sách các địa chỉ nhận
@body = '<h3 style="color: red;">Xin chào</h3>', -- nội dung email
@body_format = 'HTML', -- định dạng Email
@subject = 'Email được gửi' -- tiêu đề Email
