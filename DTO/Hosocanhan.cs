using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hosocanhan
    {
        // Thông tin hồ sơ gv
        public String Hoten { get; set; }
        public String Ngaysinh { get; set; }
        public String Anhmau { get; set; }
        public String Gioitinh { get; set; }
        public String Sdt { get; set; }
        public String Email { get; set; }
        public String Dantoc { get; set; }
        public String Tongiao { get; set; }
        public String Tengoikhac { get; set; }
        public String Doituongcs { get; set; }
        public String Xuatthan { get; set; }
        public String Hocham { get; set; }
        public String Ngayvao { get; set; }
        public String Vieclamlaunhat { get; set; }
        public String Congviecchinh { get; set; }
        public String Sotruongcongtac { get; set; }
        public String Nghenghieptruoc { get; set; }
        public String Chieucao { get; set; }
        public String Cannang { get; set; }
        public String Nhommau { get; set; }
        public String Nhanxet { get; set; }
        // Hộ khẩu thường trú
        public String Hokhautt_huyen { get; set; }
        public String Hokhautt_xa { get; set; }
        public String Hokhautt_tinh { get; set; }
        public String Hokhautt_xom { get; set; }
        public String Hokhautt_sonha { get; set; }
        public String Hokhautt_duongpho { get; set; }
        //Nơi ở hiện tại
        public String Noht_huyen { get; set; }
        public String Noht_xa { get; set; }
        public String Noht_tinh { get; set; }
        public String Noht_xom { get; set; }
        public String Noht_sonha { get; set; }
        // Thông tin cccd
        public String Socccd { get; set; }
        public String Ngaycap { get; set; }
        // Tuyển dụng lần đầu
        public String Tdld_ngaytd { get; set; }
        public String Coquan { get; set; }
        // Tham gia ctxh
        public String Tochuc { get; set; }
        public String CTXH_ngaytd { get; set; }
        public String Congviec { get; set; }
        // Nhập ngũ
        public String Quanham { get; set; }
        public String Ngaynhapngu { get; set; }
        public String Ngayxuatngu { get; set; }
        public String Ngaytaingu { get; set; }

        // Biệt phái
        public String Bp_soqd { get; set; }
        public String Bp_coquanqd { get; set; }
        public String Bp_chucvu { get; set; }
        public String Bp_ngaybanhanh { get; set; }
        public String Bp_ngaybd { get; set; }
        public String Bp_ngaykt { get; set; }
        public String Bp_vbqd { get; set; }
        // Công tác Đảng Đoàn
        public String CtDD_tochucdang { get; set; }
        public String CtDD_chucvu { get; set; }
        public String CtDD_loaitochuc { get; set; }
        public String CtDD_ngaybd { get; set; }
        public String CtDD_ngaykt { get; set; }

        //Trình độ giáo dục phổ thông
        public String Tdgdpt_Totnghieplop { get; set;}
        public String Tdgdpt_He {  get; set; }
        //Trình độ chuyên môn cao nhất
        public String Tdcmcn_Vanbanghocham { get; set; }
        public String Tdcmcn_Chuyennganh { get; set; }
        //Danh hiệu nhà nước tặng
        public String Danhhieu {  get; set; }
        public String Dh_ngaynhan {  get; set; }
        //Bồi dưỡng chuyên môn    
        public String Bdcm_hinhthucdt {  get; set; }
        public String Bdcm_chuyennganhdt { get; set; }
        public String Bdcm_tencsdt {  get; set; }
        public String Bdcm_vanbang {  get; set; }
        public String Bdcm_tungay {  get; set; }
        public String Bdcm_denngay { get; set; }
        //Bồi dưỡng lý luận chính trị
        public String Bdct_hinhthucdt { get; set; }
        public String Bdct_tencsdt { get; set; }
        public String Bdct_vanbang { get; set; }
        public String Bdct_tungay { get; set; }
        public String Bdct_denngay { get; set; }
        //Bồi dưỡng quản lý nhà nước
        public String Bdqlnn_chungchi { get; set; }
        public String Bdqlnn_tencsdt { get; set; }
        public String Bdqlnn_tungay { get; set; }
        public String Bdqlnn_denngay { get; set; }
        //  Bồi dưỡng ANQP
        public String Anqp_chungchi { get; set; }
        public String Anqp_tencsdt { get; set; }
        public String Anqp_tungay { get; set; }
        public String Anqp_denngay { get; set; }
        //Bồi dưỡng tin học
        public String Bdth_chungchi { get; set; }
        public String Bdth_tencsdt { get; set; }
        public String Bdth_tungay { get; set; }
        public String Bdth_denngay { get; set; }
        //Bồi dưỡng ngoại ngữ dân tộc
        public String Bdnndt_tennndt { get; set; }
        public String Bdnndt_chungchi { get; set; }
        public String Bdnndt_diemso {  get; set; }
        public String Bdnndt_tencsdt { get; set; }
        public String Bdnndt_tungay { get; set; }
        public String Bdnndt_denngay { get; set; }
        //Tóm tắt quá trình công tác
        public String Ttqtct_soqd {  get; set; }
        public String Ttqtct_coquanqd { get; set; }
        public String Ttqtct_ngaybh { get; set; }
        public String Ttqtct_cachthuc { get; set; }
        public String Ttqtct_tungay { get; set; }
        public String Ttqtct_denngay { get; set; }
        public String Ttqtct_donvict { get; set; }
        public String Ttqtct_chucvu { get; set; }
        public String Ttqtct_hesochucvu { get; set; }
        public String Ttqtct_ngaybn { get; set; }
        public String Ttqtct_hinhthuc { get; set; }
        public String Ttqtct_vbqd { get; set; }
        //Bị bắt bị tù
        public String Bbbt_vande {  get; set; }
        public String Bbbt_khaibaocho { get; set; }
        public String Bbbt_odau { get; set; }
        public String Bbbt_tungay { get; set; }
        public String Bbbt_denngay { get; set; }
        //Bản thân ở chế độ cũ
        public String Btocdc_donvi {  get; set; }
        public String Btocdc_diadiem {  get; set; }
        public String Btocdc_chucvu { get; set; }
        public String Btocdc_tungay { get; set; }
        public String Btocdc_denngay { get; set; }
        //Quê quán
        public String Qq_xa {  get; set; }
        public String Qq_phuong { get; set; }
        public string Qq_huyen { get; set ; }
        public string Qq_tinhthanh { get; set; }
        //Nơi sinh
        public String Ns_xa { get; set; }
        public String Ns_phuong { get; set; }
        public String Ns_huyen { get; set; }
        public String Ns_tinhthanh { get; set; }
        //Xác thực
        public String OTP_Code {  get; set; }
        public String verifyTime { get; set;}
        //Lịch sử đăng nhập
        public String LoginTime { get; set; }
        public String LogoutTime { get; set; }
        //Quan hệ tổ chức nước ngoài
        public String Qhtcnn_tentc {  get; set; }
        public String Qhtcnn_diachi {  get; set; }
        public String Qhtcnn_congviec {  get; set; }
        public String Qhtcnn_tungay { get; set; }
        public String Qhtcnn_denngay { get; set; }
        //Quan hệ gia đình
        public String Qhgd_moiqh {  get; set; }
        public String Qhgd_hoten {  get; set; }
        public String Qhgd_ngaysinh {  get; set; }
        public String Qhgd_thongtin {  get; set; }
        //Bảo hiểm
        public String Bh_tonghsluong {  get; set; }
        public String Bh_tylebhxh {  get; set; }
        public String Bh_tylebhtn {  get; set; }
        public String Bh_tylebhyt {  get; set; }
        public String Bh_tongtienluongdong {  get; set; }
        public String Bh_tungay { get; set; }
        public String Bh_denngay { get; set; }
        //Cử đi học
        public String Cdh_chuongtrinhdt {  get; set; }
        public String Cdh_truongdt {  get; set; }
        public String Cdh_hinhthuc {  get; set; }
        public String Cdh_loaitrinhdo {  get; set; }
        public String Cdh_khoadt {  get; set; }
        public String Cdh_chuyennganh {  get; set; }
        public String Cdh_trinhdo { get; set; }
        public String Cdh_namnhaphoc {  get; set; }
        public String Cdh_namTNDK {  get; set; }
        public String Cdh_nguonkinhphi {  get; set; }
        public String Cdh_ngayqd {  get; set; }
        public String Cdh_soqd {  get; set; }
        public String Cdh_coquanqd {  get; set; }
        public String Cdh_vbqd {  get; set; }
        //Khen thưởng kỷ luật
        public String Ktkl_hinhthuc { get; set; }
        public String Ktkl_lydo {  get; set; }
        public String Ktkl_tungay {  get; set; }
        public String Ktkl_denngay {  get; set; }
        public String Ktkl_soqd { get; set; }
        public String Ktkl_nguoikyqd {  get; set; }
        public String Ktkl_vbqd { get; set; }
        //Hợp đồng
        public String Hd_loaihinh {  get; set; }
        public String Hd_ngaybanhanh { get; set; }
        public String Hd_hinhthuc { get;set; }
        public String Hd_ngaytd { get; set; }
        public String Hd_ngaykt { get; set; }
        public String Hd_soqd { get; set; }
        public String Hd_coquanqd { get; set; }
        public String Hd_vbqd { get;set; }
        //Đảng đoàn
        public String Dd_loaitochuc {  get; set; }
        public String Dd_ngayvao {  get; set; }
        public String Dd_ngaychinhthuc { get; set; }
        //Lương thưởng
        public String Lt_tongheso {  get; set; }
        public String Lt_pctnvk {  get; set; }
        public String Lt_tongnhan {  get; set; }
        public String Lt_ngaynhan {  get; set; }
        //Phụ cấp
        public String Pc_loaiphucap {  get; set; }
        public String Pc_sotienhuong {  get; set; }
        //Nâng lương trước hạn
        public String Nlth_TDCTDS {  get; set; }
        public String Nlth_chenhlechbaoluu { get; set; }
        public String Nlth_thoidiemdunghan {  get; set; }
        public String Nlth_sothangnangtruochan {  get; set; }
        public String Nlth_ngayqd {  get; set; }
        public String Nlth_soqd {  get; set; }
        public String Nlth_coquanqd {  get; set; }
        public String Nlth_vbqd {  get; set; }
        //Quá trình lương
        public String Qtl_tungay {  get; set; }
        public String Qtl_denngay {  get; set; }
        public String Qtl_heso {  get; set; }
        public String Qtl_mangach {  get; set; }
        public String Qtl_bac {  get; set; }
        //Chức vụ hiện tại
        public String Cvht_tencv {  get; set; }
        public String Cvht_mangach { get; set; }
        public String Cvht_bac { get;set; }
        public String Cvht_heso { get; set; }
        //Kiêm nhiệm
        public String Kn_tencv { get; set; }
        public String Kn_mangach { get; set; }
        public String Kn_hesophucap { get; set; }






    }
}
