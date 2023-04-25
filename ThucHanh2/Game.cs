/*Tạo các lớp cơ sở (base classes) cho game: Board, Player, và Game.
Sử dụng kế thừa (Inheritance) để tạo các lớp con cho Player, như HumanPlayer và ComputerPlayer.
Tạo Abstract Class hoặc Interface để định nghĩa các phương thức chung cho các lớp con của Player.
Xử lý ngoại lệ (Exception Handling) khi nhập dữ liệu từ người dùng và trong các hàm của game.
Lưu trữ thông tin về số lần chơi và kết quả sử dụng tệp (File) và Serialization.




Board: Lớp chứa các thuộc tính và phương thức liên quan đến bảng chơi (kiểm tra thắng/thua, vẽ bảng chơi).
Player: Lớp cơ bản chứa các thuộc tính và phương thức chung của người chơi.
HumanPlayer: Lớp kế thừa từ Player, thêm các thuộc tính và phương thức riêng cho người chơi thực.
ComputerPlayer: Lớp kế thừa từ Player, thêm các thuộc tính và phương thức riêng cho máy tính chơi.
Game: Lớp chứa các phương thức và thuộc tính để quản lý game, bao gồm cả hàm main().
 */

using ThucHanh2;





Board board = new Board();
board.Play();
