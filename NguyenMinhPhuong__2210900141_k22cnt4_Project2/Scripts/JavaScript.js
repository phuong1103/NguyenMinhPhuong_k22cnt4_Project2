document.addEventListener("DOMContentLoaded", function () {
    const adressbtn = document.querySelector('#adress-form');
    const adressClose = document.querySelector('#adress-close');

    // Kiểm tra xem các phần tử có tồn tại không
    if (adressbtn && adressClose) {
        adressbtn.addEventListener("click", function () {
            document.querySelector('.adress-form').style.display = "flex";
        });

        adressClose.addEventListener("click", function () {
            document.querySelector('.adress-form').style.display = "none";
        });
    }

    // slider---------------------------------------
    const rightbtn = document.querySelector('.fa-chevron-right');
    const leftbtn = document.querySelector('.fa-chevron-left');
    const imgNumber = document.querySelectorAll('.slider-content-top img');
    const dotsContainer = document.querySelector('.slider-dots');
    let index = 0;
    let autoSlide;

    // Tạo các chấm
    function createDots() {
        dotsContainer.innerHTML = ''; // Xóa chấm cũ trước khi tạo mới
        imgNumber.forEach((_, i) => {
            const dot = document.createElement('span');
            dot.addEventListener('click', () => {
                index = i; // Cập nhật index khi nhấp vào chấm
                updateSlider();
                updateDots();
                restartAutoSlide(); // Khởi động lại cuộn tự động
            });
            dotsContainer.appendChild(dot);
        });
        updateDots(); // Cập nhật trạng thái chấm ban đầu
    }

    // Hàm cập nhật trạng thái chấm
    function updateDots() {
        const dots = document.querySelectorAll('.slider-dots span');
        dots.forEach((dot, i) => {
            dot.classList.toggle('active', i === index);
        });
    }

    // Hàm cập nhật vị trí slider
    function updateSlider() {
        const offset = -index * 100; // Tính toán offset dựa trên index
        document.querySelector(".slider-content-top").style.transform = `translateX(${offset}%)`;
        updateDots(); // Cập nhật trạng thái chấm
    }

    // Hàm bắt đầu cuộn tự động
    function startAutoSlide() {
        autoSlide = setInterval(() => {
            index++;
            if (index >= imgNumber.length) {
                index = 0; // Quay về slide đầu
            }
            updateSlider();
        }, 3000); // Thay đổi slide mỗi 3 giây
    }

    // Sự kiện cho nút bên phải
    rightbtn.addEventListener("click", function () {
        index++;
        if (index >= imgNumber.length) {
            index = 0; // Quay về slide đầu
        }
        updateSlider();
        restartAutoSlide(); // Khởi động lại cuộn tự động sau hành động thủ công
    });

    // Sự kiện cho nút bên trái
    leftbtn.addEventListener("click", function () {
        index--;
        if (index < 0) {
            index = imgNumber.length - 1; // Quay về slide cuối
        }
        updateSlider();
        restartAutoSlide(); // Khởi động lại cuộn tự động sau hành động thủ công
    });

    // Hàm khởi động lại cuộn tự động
    function restartAutoSlide() {
        clearInterval(autoSlide); // Dừng interval hiện tại
        startAutoSlide(); // Bắt đầu cuộn tự động mới
    }

    // Bắt đầu cuộn tự động khi trang tải
    createDots();
    startAutoSlide();

    // Sản phẩm
    const container = document.querySelector('.box-container');
    if (container) {
        const totalWidth = container.scrollWidth; // Tổng chiều rộng của container
        const visibleWidth = container.clientWidth; // Chiều rộng có thể nhìn thấy của container
        let currentScroll = 0; // Biến lưu vị trí cuộn hiện tại

        setInterval(() => {
            // Kiểm tra nếu đã đến cuối container
            if (currentScroll + visibleWidth >= totalWidth) {
                // Cuộn về đầu
                container.scrollTo({
                    left: 0,
                    behavior: 'smooth'
                });
                currentScroll = 0; // Đặt lại vị trí cuộn
            } else {
                // Cuộn container sang phải
                container.scrollBy({
                    top: 0,
                    left: 300, // Kích thước cần cuộn (300px)
                    behavior: 'smooth' // Hiệu ứng cuộn mượt mà
                });
                currentScroll += 300; // Cập nhật vị trí cuộn
            }
        }, 4000); // 4000ms = 4 giây
    }
});