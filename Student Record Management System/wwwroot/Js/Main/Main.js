document.addEventListener('DOMContentLoaded', function () {
    const sidebar = document.getElementById('sidebar');
    const sidebarCollapse = document.getElementById('sidebarCollapse');
    const mainContent = document.getElementById('main-content');
    const mobileSidebarToggle = document.getElementById('mobileSidebarToggle');
    const profileInfo = document.getElementById('profileInfo');
    const logoutPopup = document.getElementById('logoutPopup');

    // Sidebar collapse/expand
    sidebarCollapse?.addEventListener('click', function () {
        sidebar.classList.toggle('collapsed');
        mainContent.classList.toggle('expanded');
    });

    // Mobile sidebar toggle
    mobileSidebarToggle?.addEventListener('click', function () {
        sidebar.classList.toggle('active');
    });

    // Close sidebar on mobile when clicking outside
    document.addEventListener('click', function (event) {
        const isClickInsideSidebar = sidebar.contains(event.target);
        const isClickHamburger = mobileSidebarToggle.contains(event.target);
        const isMobile = window.innerWidth <= 768;

        if (!isClickInsideSidebar && !isClickHamburger && isMobile) {
            sidebar.classList.remove('active');
        }
    });

    // Update active nav item
    const navItems = document.querySelectorAll('.nav-item');
    navItems.forEach(item => {
        item.addEventListener('click', function () {
            navItems.forEach(navItem => navItem.classList.remove('active'));
            this.classList.add('active');

            if (window.innerWidth <= 768) {
                sidebar.classList.remove('active');
            }
        });
    });

    // Responsive resize logic
    window.addEventListener('resize', function () {
        if (window.innerWidth > 768) {
            sidebar.classList.remove('active');
        }
    });

    // Logout popup toggle
    profileInfo?.addEventListener('click', function (e) {
        e.stopPropagation();
        logoutPopup.classList.toggle('d-none');
    });

    document.addEventListener('click', function (e) {
        if (!logoutPopup.contains(e.target) && !profileInfo.contains(e.target)) {
            logoutPopup.classList.add('d-none');
        }
    });
});
