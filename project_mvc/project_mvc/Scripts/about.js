// ~/Scripts/about.js

document.addEventListener('DOMContentLoaded', function () {
    // ================= CLICKABLE CARD =================
    const cards = document.querySelectorAll('.clickable-card');

    cards.forEach(card => {
        // Click chuột
        card.addEventListener('click', function (e) {
            // Nếu bấm vào button bên trong (wishlist, nút khác) thì không redirect
            if (e.target.closest('button')) return;

            const url = this.dataset.url;
            if (url) {
                window.location.href = url;
            }
        });

        // Hỗ trợ Enter / Space khi focus (tabindex="0")
        card.addEventListener('keydown', function (e) {
            if (e.key === 'Enter' || e.key === ' ') {
                e.preventDefault();
                const url = this.dataset.url;
                if (url) {
                    window.location.href = url;
                }
            }
        });
    });

    // ================= FLASH SALE COUNTDOWN (2H) =================
    const tHour = document.getElementById('tHour');
    const tMin = document.getElementById('tMin');
    const tSec = document.getElementById('tSec');

    // Nếu không có 3 phần tử này thì bỏ qua
    if (!tHour || !tMin || !tSec) return;

    const endTime = Date.now() + 2 * 60 * 60 * 1000; // 2 giờ từ lúc tải trang

    function updateCountdown() {
        const now = Date.now();
        let diff = Math.max(0, Math.floor((endTime - now) / 1000)); // giây

        const h = String(Math.floor(diff / 3600)).padStart(2, '0');
        diff %= 3600;
        const m = String(Math.floor(diff / 60)).padStart(2, '0');
        const s = String(diff % 60).padStart(2, '0');

        tHour.textContent = h;
        tMin.textContent = m;
        tSec.textContent = s;
    }

    updateCountdown();
    setInterval(updateCountdown, 1000);
});
