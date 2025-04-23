vim.opt.rtp:prepend("~/.local/share/nvim/lazy/lazy.nvim")

require("lazy").setup({
  { "nvim-treesitter/nvim-treesitter", build = ":TSUpdate" }, 
  { "neovim/nvim-lspconfig" }, 
  { "nvim-treesitter" },
  { "nvim-cmp" },
  { "telescope.nvim" }, 
  { "williamboman/mason.nvim",
    config = function()
      require("mason").setup()
    end,
  },
  { "williamboman/mason-lspconfig.nvim" },
  { "hrsh7th/nvim-cmp" },
  { "hrsh7th/cmp-nvim-lsp" },
  { "L3MON4D3/LuaSnip" },
  { "nvim-lualine/lualine.nvim" },
  { "nvim-tree/nvim-tree.lua" },
  { "nvim-telescope/telescope.nvim" },
})

require("lspconfig").omnisharp.setup {
  cmd = { "/home/erfan/.local/share/nvim/mason/packages/omnisharp/omnisharp", "--languageserver", "--hostPID", tostring(vim.fn.getpid()) },
  enable_editorconfig_support = true,
  enable_roslyn_analyzers = true,
  organize_imports_on_format = true,
}
