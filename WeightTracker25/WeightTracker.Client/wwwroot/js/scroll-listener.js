let dotNetReference = null;
let lastScrollY = 0;
let ticking = false;
const scrollThreshold = 50; // Hide footer when scrolling down past 50px

function handleScroll() {
    lastScrollY = window.scrollY;

    if (!ticking) {
        window.requestAnimationFrame(() => {
            updateFooterVisibility();
            ticking = false;
        });

        ticking = true;
    }
}

function updateFooterVisibility() {
    if (dotNetReference) {
        // Show footer when at top (scrollY < threshold), hide when scrolling down
        const shouldShow = lastScrollY < scrollThreshold;
        dotNetReference.invokeMethodAsync('UpdateVisibility', shouldShow);
    }
}

window.initScrollListener = (dotNetRef) => {
    dotNetReference = dotNetRef;
    window.addEventListener('scroll', handleScroll, { passive: true });
    
    // Initial check - show footer by default when at top
    updateFooterVisibility();
};

window.removeScrollListener = () => {
    window.removeEventListener('scroll', handleScroll);
    dotNetReference = null;
};
