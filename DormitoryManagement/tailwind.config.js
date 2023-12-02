/** @type {import('tailwindcss').Config} */
module.exports = {
    content: {
        relative: true,
        files: [
            "./**/*.{razor,html,cshtml,js,cs}"
        ],
    },
    theme: {
        extend: {
            colors: {
                'primary': '#023047',
                'primary-hover' : '#022639'
            }
        }
    },
    plugins: [],
}

