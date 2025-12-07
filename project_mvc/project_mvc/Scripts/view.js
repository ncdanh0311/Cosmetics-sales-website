// view.js – TheFaceShop layout helpers
(function () {
    // ===============================
    // 1. FLASH SALE COUNTDOWN (2 GIỜ)
    // ===============================
    const tHour = document.getElementById("tHour");
    const tMin = document.getElementById("tMin");
    const tSec = document.getElementById("tSec");

    if (tHour && tMin && tSec) {
        const endTime = Date.now() + 2 * 60 * 60 * 1000; // +2h

        setInterval(() => {
            const now = Date.now();
            let diff = Math.max(0, Math.floor((endTime - now) / 1000));

            const h = String(Math.floor(diff / 3600)).padStart(2, "0");
            diff %= 3600;
            const m = String(Math.floor(diff / 60)).padStart(2, "0");
            const s = String(diff % 60).padStart(2, "0");

            tHour.textContent = h;
            tMin.textContent = m;
            tSec.textContent = s;
        }, 1000);
    }

    // ===============================
    // 2. VALIDATE TÌM KIẾM (DESKTOP + MOBILE)
    // ===============================
    function setupSearchValidation(formSelector, inputSelector) {
        const form = document.querySelector(formSelector);
        const input = document.querySelector(inputSelector);
        if (!form || !input) return;

        form.addEventListener("submit", function (e) {
            const value = (input.value || "").trim();
            if (!value) {
                e.preventDefault();
                input.focus();
                input.classList.add("is-invalid");
                setTimeout(() => input.classList.remove("is-invalid"), 800);
            }
        });
    }

    // Desktop search
    setupSearchValidation(".hs-search form, .hs-search-form", ".hs-search-input");
    // Mobile search (nếu có)
    setupSearchValidation("#mobileSearch form", "#mobileSearch input[name='search']");

    // ===============================
    // 3. CART DEMO – OFFCANVAS GIỎ HÀNG
    // ===============================
    const cartList = document.getElementById("cartList");
    const cartTotal = document.getElementById("cartTotal");
    const cartBadge = document.getElementById("cartBadge");

    function formatVND(n) {
        try {
            return n.toLocaleString("vi-VN") + "₫";
        } catch {
            return n + "₫";
        }
    }

    function updateTotal() {
        if (!cartList || !cartTotal) return;

        const items = cartList.querySelectorAll("[data-price]");
        let sum = 0;
        items.forEach(el => {
            const p = Number(el.getAttribute("data-price") || "0");
            if (!Number.isNaN(p)) sum += p;
        });

        cartTotal.textContent = formatVND(sum);

        if (cartBadge) {
            cartBadge.textContent = items.length.toString();
            // lưu vào localStorage nếu muốn
            try {
                localStorage.setItem("cart-count", items.length.toString());
            } catch {
                /* ignore */
            }
        }
    }

    function addItem(title, price, img) {
        if (!cartList) return;

        const li = document.createElement("li");
        li.className = "list-group-item d-flex align-items-center gap-3";
        li.setAttribute("data-price", price);

        li.innerHTML = `
            <img src="${img}" class="cart-item-thumb" alt="thumb">
            <div class="flex-grow-1">
                <div class="fw-semibold text-truncate-2">${title}</div>
                <div class="small text-secondary">${formatVND(price)}</div>
            </div>
            <button type="button" class="btn btn-sm btn-outline-danger">
                <i class="fa-solid fa-trash"></i>
            </button>
        `;

        const removeBtn = li.querySelector("button");
        if (removeBtn) {
            removeBtn.addEventListener("click", () => {
                li.remove();
                updateTotal();
            });
        }

        cartList.appendChild(li);
        updateTotal();
    }

    // Gắn sự kiện cho các nút "Thêm vào giỏ"
    if (typeof bootstrap !== "undefined" && cartList && cartTotal) {
        document.querySelectorAll(".add-to-cart").forEach(btn => {
            btn.addEventListener("click", () => {
                const title = btn.dataset.title || "Sản phẩm";
                const price = Number(btn.dataset.price || "0");
                const img = btn.dataset.img || (document.body.getAttribute("data-img-root") || "") + "no-image.png";

                addItem(title, price, price >= 0 ? img : "");

                // Mở offcanvas giỏ hàng
                try {
                    const cartOffcanvas = new bootstrap.Offcanvas("#offcanvasCart");
                    cartOffcanvas.show();
                } catch {
                    // nếu chưa load bootstrap.Offcanvas thì thôi
                }
            });
        });

        // nếu có cart-count trong localStorage → sync badge
        if (cartBadge) {
            try {
                const saved = parseInt(localStorage.getItem("cart-count") || "0", 10);
                if (!Number.isNaN(saved) && saved > 0) {
                    cartBadge.textContent = saved.toString();
                }
            } catch { /* ignore */ }
        }
    }

    // ===============================
    // 4. CLICKABLE CARD – REDIRECT PRODUCT
    // ===============================
    document.addEventListener("click", function (e) {
        const card = e.target.closest(".clickable-card");
        if (!card) return;

        // nếu click vào link / nút thì không redirect nữa
        if (e.target.closest("a, button, .tfs-btn, .tfs-wishlist")) return;

        const url = card.dataset.url;
        if (url) {
            window.location.href = url;
        }
    });

    document.addEventListener("keydown", function (e) {
        // hỗ trợ Enter / Space khi focus trong card
        const card = e.target.closest(".clickable-card");
        if (!card) return;

        if (e.key === "Enter" || e.code === "Space") {
            e.preventDefault();
            const url = card.dataset.url;
            if (url) {
                window.location.href = url;
            }
        }
    });
})();
