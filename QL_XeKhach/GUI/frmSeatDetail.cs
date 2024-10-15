using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QL_XeKhach.GUI
{
    public partial class frmSeatDetail : Form
    {
        public frmSeatDetail(List<Seat> seats)
        {
            InitializeComponent();
            RenderSeat(seats);
        }
        private void RenderSeat(List<Seat> seats)
        {
            int seatCount = seats.Count;

            if (seatCount <= 16)
            {
                RenderBusLayout(tblSeats, seats, 4, 4); // 4x4 cho xe 16 chỗ
            }
            else if (seatCount <= 30)
            {
                RenderBusLayout(tblSeats, seats, 5, 6); // 5x6 cho xe 30 chỗ
            }
            else if (seatCount <= 35)
            {
                RenderBusLayout(tblSeats, seats, 6, 6, hasAisle: true); // 6x6 có lối đi giữa cho 35 chỗ
            }
            else
            {
                RenderBusLayout(tblSeats, seats, 8, 6, hasAisle: true); // 8x6 có lối đi giữa cho 45 chỗ
            }
        }

        /// <summary>
        /// Render layout ghế dựa trên cấu hình xe.
        /// </summary>
        /// <param name="panel">TableLayoutPanel để chứa ghế.</param>
        /// <param name="seats">Danh sách ghế.</param>
        /// <param name="rows">Số hàng.</param>
        /// <param name="cols">Số cột.</param>
        /// <param name="hasAisle">Có lối đi giữa không?</param>
        public void RenderBusLayout(TableLayoutPanel panel, List<Seat> seats, int rows, int cols, bool hasAisle = false)
        {
            // Xóa các control cũ nếu có
            panel.Controls.Clear();
            panel.RowStyles.Clear();
            panel.ColumnStyles.Clear();

            // Cấu hình hàng và cột
            panel.RowCount = rows;
            panel.ColumnCount = hasAisle ? cols + 1 : cols;

            // Cấu hình tỷ lệ cho hàng và cột
            for (int i = 0; i < rows; i++)
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

            for (int j = 0; j < panel.ColumnCount; j++)
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / panel.ColumnCount));

            int seatIndex = 0;

            // Thêm ghế vào layout
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    // Bỏ qua lối đi giữa nếu có
                    if (hasAisle && j == cols / 2)
                    {
                        continue;
                    }

                    if (seatIndex >= seats.Count) break;

                    var seat = seats[seatIndex++];
                    var seatButton = new Button
                    {
                        Text = seat.SeatNumber,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(2),
                        BackColor = seat.IsBooked ? Color.Red : Color.Green,
                        ForeColor = Color.White,
                        // Tăng kích thước tối thiểu của nút
                        MinimumSize = new Size(60, 60) // Kích thước tối thiểu cho Button
                    };

                    // Thêm Button vào TableLayoutPanel
                    panel.Controls.Add(seatButton, j, i);
                }
            }
        }
    }
}
